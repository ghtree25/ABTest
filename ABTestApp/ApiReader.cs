using Newtonsoft.Json;
using System.Globalization;
using System.Net.Http.Headers;

namespace ABTestApp
{
    public class ApiReader
    {
        // https://www.cnb.cz/cs/financni-trhy/devizovy-trh/kurzy-devizoveho-trhu/kurzy-devizoveho-trhu/denni_kurz.txt

        private HttpClient _clientBtc;
        private HttpClient _clientCzkEur;

        public ApiReader()
        {
            _clientBtc = new HttpClient();
            _clientBtc.BaseAddress = new Uri("https://api.coindesk.com");
            _clientBtc.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _clientCzkEur = new HttpClient();
            _clientCzkEur.BaseAddress = new Uri("https://www.cnb.cz");
            _clientCzkEur.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/txt"));
        }

        private async Task<decimal> GetCzkEurRatio()
        {
            HttpResponseMessage response = await _clientCzkEur.GetAsync("/cs/financni-trhy/devizovy-trh/kurzy-devizoveho-trhu/kurzy-devizoveho-trhu/denni_kurz.txt");

            if (response.IsSuccessStatusCode)
            {
                string txt = await response.Content.ReadAsStringAsync();
                string[] lines = txt.Split("\n");

                foreach (string line in lines)
                {
                    // EMU|euro|1|EUR|25,230
                    if (line.StartsWith("EMU"))
                    {
                        string value = line.Split('|')[4];

                        if (decimal.TryParse(value, out decimal result))
                        {
                            return result;
                        }
                    }
                }

                throw new Exception($"Error getting CZK/EUR rate.");
            }
            else
            {
                throw new Exception($"Error acquiring CZK/EUR rate: {response.StatusCode} ({response.ReasonPhrase})");
            }
        }

        public async Task<PriceData> ReadDataAsync()
        {
            HttpResponseMessage response = await _clientBtc.GetAsync("/v1/bpi/currentprice.json");

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                dynamic dyn = JsonConvert.DeserializeObject(json);
                string timestr = dyn.time.updated;
                timestr = timestr.Replace(" UTC", "");
                // Jan 16, 2025 18:38:01 UTC

                DateTime updated = DateTime.ParseExact(timestr, "MMM dd, yyyy HH:mm:ss", CultureInfo.GetCultureInfo("en-US"), DateTimeStyles.AssumeUniversal);
                decimal eurCzkRate = await GetCzkEurRatio();

                PriceData data = new PriceData();
                data.Time = updated;
                data.USD = dyn.bpi.USD.rate_float;
                data.GBP = dyn.bpi.GBP.rate_float;
                data.EUR = dyn.bpi.EUR.rate_float;
                decimal czk = dyn.bpi.EUR.rate_float * eurCzkRate;
                data.CZK = Math.Round(czk, 4);
                return data;
            }
            else
            {
                throw new Exception($"Error acquiring data: {response.StatusCode} ({response.ReasonPhrase})");
            }
        }
    }
}
