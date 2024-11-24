using csharp_EZReserve.Data;
using csharp_EZReserve.Services;

namespace csharp_EZReserve.Forms.Reporting
{
    public partial class ReportingForm : Form
    {
        private SQLiteDbContext _dbContext;

        // Ensure minute precision for selected DateTime values
        private DateTime _selectedFromDateTime =>
            dateTimePicker_fromDate.Value.Date +
            TimeSpan.FromMinutes((int)dateTimePicker_fromTime.Value.TimeOfDay.TotalMinutes);

        private DateTime _selectedToDateTime =>
            dateTimePicker_toDate.Value.Date +
            TimeSpan.FromMinutes((int)dateTimePicker_toTime.Value.TimeOfDay.TotalMinutes);

        public ReportingForm(SQLiteDbContext dbContext)
        {
            _dbContext = dbContext;
            InitializeComponent();
        }

        private void button_exportCsv_Click(object sender, EventArgs e)
        {
            var service = new ReservationCsvExporter(_dbContext);
            try
            {
                service.Export(_selectedFromDateTime, _selectedToDateTime);

                if (service.Success)
                    MessageBox.Show($"CSV successfully exported to {service.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while exporting to CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_exportXlsx_Click(object sender, EventArgs e)
        {
            var service = new ReservationExcelExporter(_dbContext);
            try
            {
                service.Export(_selectedFromDateTime, _selectedToDateTime);

                if(service.Success)
                    MessageBox.Show($"Excel successfully exported to {service.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while exporting to Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_graph_Click(object sender, EventArgs e)
        {
            var data = (new GraphDataService(_dbContext)).FilterValues(_selectedFromDateTime, _selectedToDateTime);
            GraphReportForm form = new GraphReportForm(data, _selectedFromDateTime, _selectedToDateTime);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
