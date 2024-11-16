using Microsoft.Extensions.Configuration;

namespace csharp_EZReserve.Data
{
    public static class AppConfiguration
    {
        public static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true);

            return builder.Build();
        }
    }
}
