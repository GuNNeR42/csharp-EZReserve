using csharp_EZReserve.Data;
using csharp_EZReserve.Forms.Customers;
using csharp_EZReserve.Forms.Reservations;

namespace csharp_EZReserve.Forms
{
    public partial class MainForm : Form
    {
        private readonly SQLiteDbContext _dbContext;
        public MainForm(SQLiteDbContext dbContext)
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
            throw new NotImplementedException();
        }
    }
}
