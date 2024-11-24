using csharp_EZReserve.Data;
using csharp_EZReserve.Models.Entities;
using System.Text;

namespace csharp_EZReserve.Services
{
    public class ReservationCsvExporter(SQLiteDbContext dbContext) : BaseExporter(dbContext)
    {

        public override void Export(DateTime from, DateTime to)
        {
            // Add default export path, if not provided
            if(string.IsNullOrEmpty(_exportDirectory))
                _exportDirectory = "./";

            // Add default file name, if not provided
            if (string.IsNullOrEmpty(FileName))
            {
                FileName = $"Export_{from:dd_MM_yyyy_HH_mm}_{to:dd_MM_yyyy_HH_mm}.csv";
            }
            else
            {
                // Check if provided file name includes .csv extension and add it, if is not present
                FileName = !FileName.EndsWith(".csv", StringComparison.OrdinalIgnoreCase)
                    ? $"{FileName}.csv"
                    : FileName;
            }

            var filteredData = GetFilteredReservations(from, to);

            if (!filteredData.Any())
                throw new InvalidOperationException("No data to export for the specified range.");

            var csvData = PrepareDataForExporting(filteredData);

            File.WriteAllText(_exportPath, csvData, Encoding.UTF8);

            Success = true;
        }

        private string PrepareDataForExporting(List<CustomerReservationView> data)
        {
            var sb = new StringBuilder();

            // TODO: make headers configuration in appsettings.json
            // Write headers
            //sb.AppendLine("CustomerId,FirstName,LastName,Email,ReservationId,Room,ReservationFrom,ReservationTo");

            // Write data
            foreach (var item in data)
            {
                sb.AppendLine($"{item.CustomerId},{item.FirstName},{item.LastName},{item.Email}," +
                              $"{item.ReservationId},{item.Room}," +
                              $"{item.ReservationFrom:yyyy-MM-dd HH:mm},{item.ReservationTo:yyyy-MM-dd HH:mm}");
            }

            return sb.ToString();
        }
    }
}
