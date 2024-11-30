using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace csharp_EZReserve.Data
{
    public class MySqlDbContext : BaseDbContext
    {
        public MySqlDbContext(IConfiguration config) : base(config) { }

        protected override void ConfigureDatabase(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _config.GetConnectionString("MySQLConnection");

            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("MySQL connection string is not configured.");

            optionsBuilder.UseMySQL(connectionString);
        }
    }
}
