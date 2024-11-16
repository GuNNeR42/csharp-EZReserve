using csharp_EZReserve.Data;
using csharp_EZReserve.Models.Entities;
using System.ComponentModel;

namespace csharp_EZReserve.Forms
{
    public partial class CustomersDataForm : Form
    {
        private readonly SQLiteDbContext _dbContext;
        private BindingList<Customer> customers;

        public CustomersDataForm(SQLiteDbContext dbContext)
        {
            _dbContext = dbContext;

            InitializeComponent();

            customers = new BindingList<Customer>(_dbContext.Customers.ToList());
        }

        private void CustomersDataForm_Load(object sender, EventArgs e)
        {
            #region Columns custom name
            dataGridView_customers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerId",
                HeaderText = "Id"
            });
            dataGridView_customers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FirstName",
                HeaderText = "Jméno"
            });
            dataGridView_customers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LastName",
                HeaderText = "Příjmení"
            });
            dataGridView_customers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email"
            });
            dataGridView_customers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StreetAddress",
                HeaderText = "Adresa"
            });

            dataGridView_customers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "City",
                HeaderText = "Město"
            });
            dataGridView_customers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PostalCode",
                HeaderText = "PSČ"
            });
            #endregion

            dataGridView_customers.DataSource = customers;
        }

        private void button_details_Click(object sender, EventArgs e)
        {

        }
    }
}
