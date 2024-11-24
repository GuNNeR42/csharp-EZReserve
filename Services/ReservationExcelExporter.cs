﻿using csharp_EZReserve.Data;
using csharp_EZReserve.Models.Entities;
using OfficeOpenXml;

namespace csharp_EZReserve.Services
{
    public class ReservationExcelExporter(SQLiteDbContext dbContext) : BaseExporter(dbContext)
    {
        public override void Export(DateTime from, DateTime to)
        {
            // Add default export path, if not provided
            if (string.IsNullOrEmpty(_exportDirectory))
                _exportDirectory = "./";

            // Add default file name, if not provided
            if (string.IsNullOrEmpty(FileName))
            {
                FileName = $"Export_{from:dd_MM_yyyy_HH_mm}_{to:dd_MM_yyyy_HH_mm}.xlsx";
            }
            else
            {
                // Check if provided file name includes .csv extension and add it, if is not present
                FileName = !FileName.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase)
                    ? $"{FileName}.xlsx"
                    : FileName;
            }

            var filteredData = GetFilteredReservations(from, to);

            if (!filteredData.Any())
                throw new InvalidOperationException("No data to export for the specified range.");

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Reservations");

                PrepareDataForExporting(filteredData, worksheet);

                package.SaveAs(new FileInfo(_exportPath));
            }

            Success = true;
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