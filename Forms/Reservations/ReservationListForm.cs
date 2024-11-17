using csharp_EZReserve.Data;
using csharp_EZReserve.Models.Entities;
using System.ComponentModel;

namespace csharp_EZReserve.Forms.Reservations
{
    public partial class ReservationListForm : Form
    {
        private readonly SQLiteDbContext _dbContext;
        private BindingList<Reservation> _reservations;
        private List<Customer> _customers;
        public ReservationListForm(SQLiteDbContext dbContext)
        {
            _dbContext = dbContext;

            InitializeComponent();

            _reservations = new BindingList<Reservation>(_dbContext.Reservations.ToList());
            _customers = _dbContext.Customers.ToList();
        }

        private void ReservationsDataForm_Load(object sender, EventArgs e)
        {
            #region Reservation DataGridView custom column names
            dataGridView_reservations.AutoGenerateColumns = false;

            dataGridView_reservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ReservationId",
                HeaderText = "Id"
            });

            dataGridView_reservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Customer",
                HeaderText = "Jméno zákazníka",
                Name = "Customer"

            });

            dataGridView_reservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerId",
                HeaderText = "Id zákazníka",
                Visible = false
            });

            dataGridView_reservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Room",
                HeaderText = "Místnost"
            });

            dataGridView_reservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "From",
                HeaderText = "Začátek rezervace"
            });

            dataGridView_reservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "To",
                HeaderText = "Konec rezervace"
            });
            #endregion

            dataGridView_reservations.DataSource = _reservations;
        }

        private void button_details_Click(object sender, EventArgs e)
        {
            int index = dataGridView_reservations.CurrentRow.Index;
            if (index < 0) return;

            Reservation reservation = _reservations[index];
            ReservationDetailForm form = new ReservationDetailForm(reservation);

            form.ShowDialog();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();

            ReservationAddEditForm form = new ReservationAddEditForm(reservation, _dbContext);
            form.Text = "Add new reservation";
            if(DialogResult.OK == form.ShowDialog())
            {
                // Add Reservaton to database
                _dbContext.Reservations.Add(reservation);
                _dbContext.SaveChanges();

                // Add Reservaton to Binding List
                _reservations.Add(reservation);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int index = dataGridView_reservations.CurrentRow.Index;
            if (index < 0) return;

            Reservation reservation = _reservations[index];
            ReservationAddEditForm form = new ReservationAddEditForm(reservation, _dbContext, updating: true);
            form.Text = "Update reservation";

            if(DialogResult.OK == form.ShowDialog())
            {
                _dbContext.Reservations.Update(reservation);
                _dbContext.SaveChanges();

                _reservations[index] = reservation;
            }

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int index = dataGridView_reservations.CurrentRow.Index;
            if (index < 0) return;

            Reservation reservation = _reservations[index];

            // Show confirmation dialog
            var result = MessageBox.Show(
                $"Are you sure you want to delete this reservation?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes) return;

            _dbContext.Reservations.Remove(reservation);
            _dbContext.SaveChanges();

            _reservations.Remove(reservation);

        }
    }
}
