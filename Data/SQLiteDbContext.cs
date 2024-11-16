using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace csharp_EZReserve.Data
{
    public class SQLiteDbContext : DbContext
    {
        // Retrieve connection string from appSettings.json
        private readonly string _connectionString;

        public SQLiteDbContext()
        {
            var config = AppConfiguration.GetConfiguration();
            _connectionString = config.GetConnectionString("SqliteConnection")!;
        }

        // Initiale DbSets for models and set data source

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite("Data Source=CustomerEvidence.db");
        }
    }
}
