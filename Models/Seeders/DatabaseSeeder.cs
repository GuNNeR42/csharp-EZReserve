using csharp_EZReserve.Data;
using Microsoft.Extensions.Logging;

namespace csharp_EZReserve.Models.Seeders
{
    public class DatabaseSeeder
    {
        private readonly BaseDbContext _dbContext;
        private readonly ILogger<DatabaseSeeder> _logger;
        public DatabaseSeeder(
            BaseDbContext appDbContext,
            ILogger<DatabaseSeeder> logger)
        {
            _dbContext = appDbContext;
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
            if (!_dbContext.Customers.Any())
            {
                _logger.LogInformation("Seeding customers...");
                var seeder = new CustomerSeeder(_dbContext, withReservations);
                await seeder.SeedAsync(count);
            }
        }
    }
}
