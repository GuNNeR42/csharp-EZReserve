using csharp_EZReserve.Data;
using csharp_EZReserve.Models.Entities;
using OfficeOpenXml;

namespace csharp_EZReserve.Services
{
    public class ReservationExcelExporter(BaseDbContext dbContext) : BaseExporter(dbContext)
    {
        protected override string FileExtension => ".xlsx";

        protected override void ExportData(List<CustomerReservationView> data)
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Reservations");

                PrepareDataForExporting(data, worksheet);

                package.SaveAs(new FileInfo(ExportPath));
            }
        }

        private void PrepareDataForExporting(List<CustomerReservationView> data, ExcelWorksheet worksheet)
        {
            // TODO: make headers configuration in appsettings.json
            // Headers
            //var headers = new[] { "CustomerId", "FirstName", "LastName", "Email", "ReservationId", "Room", "ReservationFrom", "ReservationTo" };

            //for (int col = 1; col <= headers.Length; col++)
            //{
            //    worksheet.Cells[1, col].Value = headers[col - 1];
            //    worksheet.Cells[1, col].Style.Font.Bold = true;
            //    worksheet.Cells[1, col].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            //    worksheet.Cells[1, col].Style.Fill.BackgroundColor.SetColor(Color.LightGray);
            //}

            // Data
            for (int row = 0; row < data.Count; row++)
            {
                var item = data[row];
                worksheet.Cells[row + 2, 1].Value = item.CustomerId;
                worksheet.Cells[row + 2, 2].Value = item.FirstName;
                worksheet.Cells[row + 2, 3].Value = item.LastName;
                worksheet.Cells[row + 2, 4].Value = item.Email;
                worksheet.Cells[row + 2, 5].Value = item.ReservationId;
                worksheet.Cells[row + 2, 6].Value = item.Room;
                worksheet.Cells[row + 2, 7].Value = item.ReservationFrom.ToString("yyyy-MM-dd HH:mm");
                worksheet.Cells[row + 2, 8].Value = item.ReservationTo.ToString("yyyy-MM-dd HH:mm");
            }

            // Autofit columns for better readability
            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
        }
    }
}
