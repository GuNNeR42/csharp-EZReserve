using csharp_EZReserve.Data;
using csharp_EZReserve.Models.Entities;
using System.ComponentModel;

namespace csharp_EZReserve.Forms.Customers
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
            #region DataGridView custom column names
            dataGridView_customers.AutoGenerateColumns = false;

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
            int index = dataGridView_customers.CurrentRow.Index;
            if (index < 0) return;

            Customer customer = customers[index];
            CustomerDetailsForm form = new CustomerDetailsForm(customer);

            form.ShowDialog();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            AddUpdateCustomerForm form = new AddUpdateCustomerForm(customer);
            form.Text = "Add Customer";

            if (DialogResult.OK == form.ShowDialog())
            {
                // Add customer to database
                _dbContext.Customers.Add(customer);
                _dbContext.SaveChanges();

                // Add customer to Binding List
                customers.Add(customer);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int index = dataGridView_customers.CurrentRow.Index;
            if (index < 0) return;

            Customer customer = customers[index];
            AddUpdateCustomerForm form = new AddUpdateCustomerForm(customer);
            form.Text = "Update Customer";

            if (DialogResult.OK == form.ShowDialog())
            {
                // Update customer in database
                _dbContext.Customers.Update(customer);
                _dbContext.SaveChanges();

                // Update customer in Binding List
                customers[index] = customer;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int index = dataGridView_customers.CurrentRow.Index;
            if (index < 0) return;

            Customer customer = customers[index];

            // Show confirmation dialog
            var result = MessageBox.Show(
                $"Are you sure you want to delete {customer.FullName} and all his/her reservations?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes) return;

            // Remove customer from database
            _dbContext.Customers.Remove(customer);
            _dbContext.SaveChanges();

            // Remove customer from Binding List
            customers.Remove(customer);
        }
    }
}
