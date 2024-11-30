using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace csharp_EZReserve.Data
{
    public class SQLiteDbContext(IConfiguration config) : BaseDbContext(config)
    {
        protected override void ConfigureDatabase(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _config.GetConnectionString("SqliteConnection");

            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("SQLite connection string is not configured.");

            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
