using csharp_EZReserve.Data;
using Microsoft.Extensions.Logging;

namespace csharp_EZReserve.Models.Seeders
{
    public class DatabaseSeeder
    {
        private readonly SQLiteDbContext _sqliteContext;
        private readonly ILogger<DatabaseSeeder> _logger;
        public DatabaseSeeder(
            SQLiteDbContext sqliteContext,
            ILogger<DatabaseSeeder> logger)
        {
            _sqliteContext = sqliteContext;
            _logger = logger;
        }
        public async Task SeedAllAsync(int? count = null)
        {
            try
            {
                await SeedCustomersAsync(count);
                _logger.LogInformation("Database seeding completed successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while seeding the databases.");
                throw;
            }
        }
        private async Task SeedCustomersAsync(int? count = null, bool withReservations = true)
        {
            if (!_sqliteContext.Customers.Any())
            {
                _logger.LogInformation("Seeding customers...");
                var seeder = new CustomerSeeder(_sqliteContext, withReservations);
                await seeder.SeedAsync(count);
            }
        }
    }
}
