using csharp_EZReserve.Data;
using csharp_EZReserve.Models.Entities;
using System.Text;

namespace csharp_EZReserve.Services
{
    public class ReservationCsvExporter(SQLiteDbContext dbContext) : BaseExporter(dbContext)
    {
        protected override string FileExtension => ".csv";

        protected override void ExportData(List<CustomerReservationView> data)
        {
            var csvData = PrepareDataForExporting(data);

            File.WriteAllText(ExportPath, csvData, Encoding.UTF8);
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
