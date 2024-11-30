using csharp_EZReserve.Data;
using csharp_EZReserve.Models.Entities;

namespace csharp_EZReserve.Forms.Reservations
{
    public partial class ReservationAddEditForm : Form
    {
        private BaseDbContext _dbContext;
        private Reservation _currentReservation;
        private bool _updating;
        private List<Customer> _customers;
        private List<Reservation> _reservations;
        private List<string> _rooms = new List<string>
        {
            "Room L101",
            "Room L102",
            "Room L201",
            "Room L202",
            "Room L301",
            "Room L302"
        };

        // Ensure minute precision for selected DateTime values
        private DateTime _selectedFromDateTime =>
            dateTimePicker_fromDate.Value.Date +
            TimeSpan.FromMinutes((int)dateTimePicker_fromTime.Value.TimeOfDay.TotalMinutes);

        private DateTime _selectedToDateTime =>
            dateTimePicker_toDate.Value.Date +
            TimeSpan.FromMinutes((int)dateTimePicker_toTime.Value.TimeOfDay.TotalMinutes);

        // Get the current time truncated to minute precision
        private DateTime CurrentTimeTruncated =>
            DateTime.Now.Date + TimeSpan.FromMinutes((int)DateTime.Now.TimeOfDay.TotalMinutes);


        public ReservationAddEditForm(Reservation currentReservation, BaseDbContext dbContext, bool updating = false)
        {
            _dbContext = dbContext;
            _currentReservation = currentReservation;
            _updating = updating;
            _customers = _dbContext.Customers.ToList();
            _reservations = _dbContext.Reservations.ToList();

            InitializeComponent();
        }

        private void AddUpdateReservationForm_Load(object sender, EventArgs e)
        {
            if(_updating && _currentReservation?.Customer != null)
            {
                // Restrict the customer change by showing only the current customer in the ComboBox
                comboBox_customers.DataSource = new List<Customer> { _currentReservation.Customer };
                comboBox_customers.Enabled = false; // Disable to prevent changes
            }
            else
            {
                comboBox_customers.DataSource = _customers;
                comboBox_customers.Enabled = true;
            }
            comboBox_customers.DisplayMember = nameof(Customer.FullName);
            comboBox_customers.ValueMember = nameof(Customer.CustomerId);

            comboBox_rooms.DataSource = _rooms;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) return;
            if (this.OverlapsWithAnotherReservation())
            {
                MessageBox.Show(
                    "Selected dates overlap with existing reservation for this room",
                    "Overlapping reservations",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning );
                return;
            }
            _currentReservation.CustomerId = (int)comboBox_customers.SelectedValue!;
            _currentReservation.Room = (string)comboBox_rooms.SelectedValue!;
            _currentReservation.From = _selectedFromDateTime;
            _currentReservation.To = _selectedToDateTime;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dateTimePicker_fromTime_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;

            if (_selectedFromDateTime < CurrentTimeTruncated)
            {
                errorProvider_validate.SetError(dtp, "Date must not be in past");
                e.Cancel = true;
            }
            else
            {
                errorProvider_validate.SetError(dtp, "");
            }
        }

        private void dateTimePicker_toTime_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;

            if (_selectedToDateTime < CurrentTimeTruncated)
            {
                errorProvider_validate.SetError(dtp, "Date must not be in past");
                e.Cancel = true;
            }
            else if (_selectedToDateTime < _selectedFromDateTime)
            {
                errorProvider_validate.SetError(dtp, "Ending date must be after starting date");
                e.Cancel = true;
            }
            else
            {
                errorProvider_validate.SetError(dtp, "");
            }
        }

        private void comboBox_customers_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (comboBox_customers.SelectedIndex < 0)
            {
                errorProvider_validate.SetError(comboBox_customers, "Choose customer");
                e.Cancel = true;
            }
            else
            {
                errorProvider_validate.SetError(comboBox_customers, "");
            }
        }

        private void comboBox_rooms_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (comboBox_rooms.SelectedIndex < 0)
            {
                errorProvider_validate.SetError(comboBox_rooms, "Choose room");
                e.Cancel = true;
            }
            else
            {
                errorProvider_validate.SetError(comboBox_rooms, "");
            }
        }

        private bool OverlapsWithAnotherReservation()
        {
            return _reservations.Any(re =>
                re.Room == (string)comboBox_rooms.SelectedValue! &&
                re.ReservationId != _currentReservation.ReservationId &&
                re.From < _selectedToDateTime && re.To > _selectedFromDateTime
            );
        }
    }
}
