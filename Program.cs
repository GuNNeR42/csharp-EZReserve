using csharp_EZReserve.Data;
using csharp_EZReserve.Forms;
using csharp_EZReserve.Models.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace csharp_EZReserve
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            try
            {
                // Load configuration
                var configuration = AppConfiguration.GetConfiguration();
                var databaseProvider = configuration["DatabaseProvider"];
                BaseDbContext dbContext;

                // Validate the database provider
                if (string.IsNullOrEmpty(databaseProvider))
                {
                    throw new InvalidOperationException("Database provider is not specified in the configuration.");
                }

                // Select the appropriate DbContext
                dbContext = databaseProvider switch
                {
                    "SQLite" => new SQLiteDbContext(configuration),
                    "MySQL" => new MySqlDbContext(configuration),
                    _ => throw new InvalidOperationException($"Unsupported database provider: {databaseProvider}")
                };


                // Ensure database is created and up to date
                await dbContext.Database.MigrateAsync();

                // Configure logging
                using var loggerFactory = LoggerFactory.Create(builder =>
                {
                    builder
                        .SetMinimumLevel(LogLevel.Information);
                });

                var logger = loggerFactory.CreateLogger<DatabaseSeeder>();

                // Initialize and run seeder
                var seeder = new DatabaseSeeder(dbContext, logger);
                await seeder.SeedAllAsync(100);

                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm(dbContext));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Application initalization error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}