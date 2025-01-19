using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace ABTestApp
{
    public class PriceDbContext : DbContext
    {
        public DbSet<PriceData> Prices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            ConnectionStringSettings setting = settings["myConnection"];
            optionsBuilder.UseSqlServer(setting.ConnectionString);
        }
    }
}
