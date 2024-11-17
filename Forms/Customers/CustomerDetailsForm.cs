using csharp_EZReserve.Models.Entities;

namespace csharp_EZReserve.Forms.Customers
{
    public partial class CustomerDetailsForm : Form
    {
        private Customer _customer;
        public CustomerDetailsForm(Customer customer)
        {
            _customer = customer;

            InitializeComponent();

            label_firstName_data.Text = customer.FirstName;
            label_lastName_data.Text = customer.LastName;
            label_email_data.Text = customer.Email;
            label_streetAddress_data.Text = customer.StreetAddress;
            label_city_data.Text = customer.City;
            label_postalCode_data.Text = customer.PostalCode;

            dataGridView_customerReservations.DataSource = customer.Reservations;
        }
    }
}
