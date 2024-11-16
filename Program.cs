using csharp_EZReserve.Data;
using csharp_EZReserve.Forms;

namespace csharp_EZReserve
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Verify configuration is accessible
            var configuration = AppConfiguration.GetConfiguration();

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}