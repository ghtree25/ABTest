using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using Timer = System.Timers.Timer;

namespace ABTestApp
{
    public partial class MainForm : Form
    {
        private PriceDbContext? _dbContext;
        private Timer _timer;
        private ApiReader _reader;
        private DateTime? _lastAdded;
        private bool _loading;

        public MainForm()
        {
            InitializeComponent();
            _timer = new Timer(10000);
            _reader = new ApiReader();
            dvSavedData.Columns["columnTime"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
        }

        protected override void OnLoad(EventArgs e)
        {
            _loading = true;

            try
            {
                base.OnLoad(e);
                cbCurrency.SelectedIndex = 0;
                btSaveLive.Enabled = false;
                btSave.Enabled = false;
                _dbContext = new PriceDbContext();

                // Uncomment the line below to start fresh with a new database.
                // _dbContext.Database.EnsureDeleted();
                // _dbContext.Database.EnsureCreated();
                _dbContext.Prices.Load();
                priceDataBindingSource.DataSource = _dbContext.Prices.Local.ToBindingList();
                _timer.Elapsed += Tick;
                _timer.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _loading = false;
            }
        }

        private decimal GetLiveValue(DataGridViewCellCollection cell)
        {
            switch (cbCurrency.SelectedIndex)
            {
                case 0:
                    return (decimal)cell[1].Value;
                case 1:
                    return (decimal)cell[2].Value;
                case 2:
                    return (decimal)cell[3].Value;
                case 3:
                    return (decimal)cell[4].Value;
                default:
                    return (decimal)cell[5].Value;
            }
        }

        private decimal GetSavedValue(PriceData data)
        {
            switch (cbCurrency.SelectedIndex)
            {
                case 0:
                    return data.USD;
                case 1:
                    return data.GBP;
                case 2:
                    return data.EUR;
                case 3:
                    return data.CZK;
                default:
                    return data.USD;
            }
        }

        private void DrawChart()
        {
            if (_loading)
            {
                return;
            }

            chart.Series[0].Points.Clear();
            DataGridView gridView = dvLiveData;

            if (rbSavedData.Checked)
            {
                gridView = dvSavedData;
                chart.ChartAreas[0].AxisX.LabelStyle.Format = "dd.M. HH:mm";
            }
            else
            {
                chart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            }

            Func<DataGridViewCellCollection, object> getLiveValue = cell =>
            {
                switch (cbCurrency.SelectedIndex)
                {
                    case 0:
                        return cell[2].Value;
                    case 1:
                        return cell[3].Value;
                    case 2:
                        return cell[4].Value;
                    case 3:
                        return cell[5].Value;
                    default:
                        return cell[2].Value;

                }
            };

            Func<PriceData, decimal> getSavedValue = pd =>
            {
                switch (cbCurrency.SelectedIndex)
                {
                    case 0:
                        return pd.USD;
                    case 1:
                        return pd.GBP;
                    case 2:
                        return pd.EUR;
                    case 3:
                        return pd.CZK;
                    default:
                        return pd.USD;

                }
            };

            decimal miny = decimal.MaxValue;
            decimal maxy = decimal.MinValue;
            DateTime minx = DateTime.MaxValue;
            DateTime maxx = DateTime.MinValue;

            foreach (DataGridViewRow row in gridView.Rows)
            {
                decimal? rate = null;
                DateTime? time = null;

                if (rbLiveData.Checked)
                {
                    rate = GetLiveValue(row.Cells);
                    time = (DateTime)row.Cells[0].Value;
                }
                else
                {
                    PriceData data = (PriceData)row.DataBoundItem;

                    if (data != null)
                    {
                        rate = GetSavedValue(data);
                        time = data.Time;
                    }
                }

                if (!rate.HasValue || !time.HasValue)
                {
                    continue;
                }

                if (chart.ChartAreas[0].AxisX.Minimum > time.Value.ToOADate())
                {
                    chart.ChartAreas[0].AxisX.Minimum = time.Value.ToOADate();
                }

                if (chart.ChartAreas[0].AxisX.Maximum < time.Value.ToOADate())
                {
                    chart.ChartAreas[0].AxisX.Maximum = time.Value.ToOADate();
                }

                if (chart.ChartAreas[0].AxisY.Minimum > (double)rate.Value)
                {
                    chart.ChartAreas[0].AxisY.Minimum = (double)rate.Value;
                }

                if (chart.ChartAreas[0].AxisY.Maximum < (double)rate.Value)
                {
                    chart.ChartAreas[0].AxisY.Maximum = (double)rate.Value;
                }

                chart.Series[0].Points.AddXY(time.Value, rate);

                if (miny > rate.Value)
                {
                    miny = rate.Value;
                }

                if (maxy < rate.Value)
                {
                    maxy = rate.Value;
                }

                if (minx > time.Value)
                {
                    minx = time.Value;
                }

                if (maxx < time.Value)
                {
                    maxx = time.Value;
                }
            }

            if (minx != maxx)
            {
                chart.ChartAreas[0].AxisX.Minimum = minx.ToOADate();
                chart.ChartAreas[0].AxisX.Maximum = maxx.ToOADate();
            }
            else
            {
                chart.ChartAreas[0].AxisX.Minimum = minx.ToOADate();
                chart.ChartAreas[0].AxisX.Maximum = maxx.AddHours(1).ToOADate();
            }

            if (miny != maxy)
            {
                chart.ChartAreas[0].AxisY.Minimum = (double)miny;
                chart.ChartAreas[0].AxisY.Maximum = (double)maxy;
            }
            else
            {
                chart.ChartAreas[0].AxisY.Minimum = (double)miny;
                chart.ChartAreas[0].AxisY.Maximum = (double)maxy + 1;
            }

            chart.Invalidate();
        }

        private async void Tick(object? sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                PriceData data = await _reader.ReadDataAsync();

                if (_lastAdded.HasValue && _lastAdded == data.Time)
                {
                    return;
                }

                _lastAdded = data.Time;

                if (InvokeRequired)
                {
                    Invoke(() =>
                    {
                        dvLiveData.Rows.Add(data.Time, data.USD, data.GBP, data.EUR, data.CZK);
                        DrawChart();
                        btSaveLive.Enabled = true;
                        laMessage.Text = "";
                    });
                }
            }
            catch (Exception ex)
            {
                if (InvokeRequired)
                {
                    Invoke(() =>
                    {
                        laMessage.Text = ex.Message;
                    });
                }
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _timer.Stop();
            _timer?.Dispose();
            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            _dbContext?.SaveChanges();
            btSave.Enabled = false;
        }

        private void dvSavedData_SelectionChanged(object sender, EventArgs e)
        {
            btDelete.Enabled = dvSavedData.SelectedRows.Count > 0;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (_dbContext != null)
            {
                foreach (DataGridViewRow row in dvSavedData.SelectedRows)
                {
                    PriceData data = (PriceData)row.DataBoundItem;

                    if (data != null)
                    {
                        _dbContext.Remove(data);
                    }
                }

                _dbContext.SaveChanges();
                dvSavedData.Refresh();
            }
        }

        private void btSaveLive_Click(object sender, EventArgs e)
        {
            if (_dbContext == null)
            {
                return;
            }

            foreach (DataGridViewRow row in dvLiveData.Rows)
            {
                var time = row.Cells["Time"].Value;
                var usd = row.Cells["USD"].Value;
                var gbp = row.Cells["GBP"].Value;
                var eur = row.Cells["EUR"].Value;
                var czk = row.Cells["CZK"].Value;

                if (time == null || usd == null || gbp == null || eur == null || czk == null)
                {
                    continue;
                }

                PriceData data = new PriceData();
                data.Time = (DateTime)time;
                data.USD = (decimal)usd;
                data.GBP = (decimal)gbp;
                data.EUR = (decimal)eur;
                data.CZK = (decimal)czk;

                if (!_dbContext.Prices.Any(x => x.Time == data.Time))
                {
                    _dbContext.Prices.Add(data);
                }
            }

            _dbContext?.SaveChanges();
            dvSavedData.Refresh();
            laMessage.Text = "Live data saved.";
            btSaveLive.Enabled = false;
            DrawChart();
        }

        private void dvSavedData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btSave.Enabled = true;
        }

        private void cbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawChart();
        }

        private void rbLiveData_CheckedChanged(object sender, EventArgs e)
        {
            DrawChart();
        }
    }
}
