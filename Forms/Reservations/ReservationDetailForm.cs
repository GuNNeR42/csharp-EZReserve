using csharp_EZReserve.Forms.Customers;
using csharp_EZReserve.Models.Entities;

namespace csharp_EZReserve.Forms.Reservations
{
    public partial class ReservationDetailForm : Form
    {
        private Reservation _reservation;
        public ReservationDetailForm(Reservation reservation)
        {
            _reservation = reservation;

            InitializeComponent();

            label_room_data.Text = _reservation.Room;
            label_customer_data.Text = _reservation.Customer.FullName;
            label_from_data.Text = _reservation.From.ToString();
            label_to_data.Text = _reservation.To.ToString();
        }

        private void button_customerDetails_Click(object sender, EventArgs e)
        {
            Customer customer = _reservation.Customer;

            CustomerDetailsForm form = new CustomerDetailsForm(customer);

            form.ShowDialog();
        }
    }
}
