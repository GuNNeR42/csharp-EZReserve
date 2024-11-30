using csharp_EZReserve.Data;
using csharp_EZReserve.Forms.Customers;
using csharp_EZReserve.Forms.Reporting;
using csharp_EZReserve.Forms.Reservations;

namespace csharp_EZReserve.Forms
{
    public partial class MainForm : Form
    {
        private readonly BaseDbContext _dbContext;
        public MainForm(BaseDbContext dbContext)
        {
            _dbContext = dbContext;

            InitializeComponent();
        }

        private void button_customers_Click(object sender, EventArgs e)
        {
            // Open Customer form
            CustomerListForm form = new CustomerListForm(_dbContext);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button_reservations_Click(object sender, EventArgs e)
        {
            // Open Reservations form
            ReservationListForm form = new ReservationListForm(_dbContext);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button_reporting_Click(object sender, EventArgs e)
        {
            ReportingForm from = new ReportingForm(_dbContext);
            this.Hide();
            from.ShowDialog();
            this.Show();
        }
    }
}
