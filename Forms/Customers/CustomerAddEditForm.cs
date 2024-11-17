using csharp_EZReserve.Models.Entities;
using System.Text.RegularExpressions;

namespace csharp_EZReserve.Forms.Customers
{
    public partial class CustomerAddEditForm : Form
    {
        private Customer _customer;
        public CustomerAddEditForm(Customer customer)
        {
            _customer = customer;

            InitializeComponent();

            textBox_firstName.Text = customer.FirstName;
            textBox_lastName.Text = customer.LastName;
            textBox_email.Text = customer.Email;
            textBox_streetAddress.Text = customer.StreetAddress;
            textBox_city.Text = customer.City;
            textBox_postalCode.Text = customer.PostalCode;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) return;

            _customer.FirstName = textBox_firstName.Text;
            _customer.LastName = textBox_lastName.Text;
            _customer.Email = textBox_email.Text;
            _customer.StreetAddress = textBox_streetAddress.Text;
            _customer.City  = textBox_city.Text;
            _customer.PostalCode = textBox_postalCode.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox_firstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (string.IsNullOrEmpty(tb.Text))
            {
                e.Cancel = true;
                errorProvider_validate.SetError(tb, "First name must be entered.");
            }
            else
            {
                errorProvider_validate.SetError(tb, "");
            }
        }

        private void textBox_lastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (string.IsNullOrEmpty(tb.Text))
            {
                e.Cancel = true;
                errorProvider_validate.SetError(tb, "Last name must be entered.");
            }
            else
            {
                errorProvider_validate.SetError(tb, "");
            }
        }

        private void textBox_email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

            if (!regex.IsMatch(tb.Text))
            {
                e.Cancel = true;
                errorProvider_validate.SetError(tb, "Email is not in correct format.");
            }
            else
            {
                errorProvider_validate.SetError(tb, "");
            }
        }

        private void textBox_streetAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (string.IsNullOrEmpty(tb.Text))
            {
                e.Cancel = true;
                errorProvider_validate.SetError(tb, "Street address must be entered.");
            }
            else
            {
                errorProvider_validate.SetError(tb, "");
            }
        }

        private void textBox_city_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (string.IsNullOrEmpty(tb.Text))
            {
                e.Cancel = true;
                errorProvider_validate.SetError(tb, "City must be entered.");
            }
            else
            {
                errorProvider_validate.SetError(tb, "");
            }
        }

        private void textBox_postalCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            // Check postal code to be in format of "190 00" or "19000"
            Regex regex = new Regex(@"^\d{3}\s?\d{2}$");

            if (!regex.IsMatch(tb.Text))
            {
                e.Cancel = true;
                errorProvider_validate.SetError(tb, "Postal code is not in correct format.");
            }
            else
            {
                errorProvider_validate.SetError(tb, "");
            }
        }
    }
}
