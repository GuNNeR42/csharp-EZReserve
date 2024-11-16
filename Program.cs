using csharp_EZReserve.Data;
using csharp_EZReserve.Forms;
using Microsoft.Extensions.Configuration;

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
                // Verify configuration is accessible
                var configuration = AppConfiguration.GetConfiguration();

                if (string.IsNullOrEmpty(configuration.GetConnectionString("SQLiteConnection")))
                {
                    throw new InvalidOperationException("Database connection strings are not properly configured.");
                }

                using var sqliteContext = new SQLiteDbContext();

                // Ensure database is created
                await sqliteContext.Database.EnsureCreatedAsync();

                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm(sqliteContext));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Application initalization error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
        }
}