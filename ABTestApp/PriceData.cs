using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABTestApp
{
    [PrimaryKey("Id")]
    public class PriceData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int Id { get; }
        public DateTime Time{ get; set; }
        public decimal USD { get; set; }
        public decimal EUR { get; set; }
        public decimal GBP { get; set; }
        public decimal CZK { get; set; }
        public string? Note { get; set; }
    }
}
