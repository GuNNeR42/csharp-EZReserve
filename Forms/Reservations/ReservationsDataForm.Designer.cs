namespace csharp_EZReserve.Forms.Reservations
{
    partial class ReservationsDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_delete = new Button();
            button_update = new Button();
            button_details = new Button();
            button_add = new Button();
            dataGridView_reservations = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_reservations).BeginInit();
            SuspendLayout();
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_delete.Location = new Point(439, 416);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(139, 26);
            button_delete.TabIndex = 3;
            button_delete.Text = "Delete Reservation";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_update
            // 
            button_update.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_update.Location = new Point(294, 416);
            button_update.Name = "button_update";
            button_update.Size = new Size(139, 26);
            button_update.TabIndex = 4;
            button_update.Text = "Update Reservation";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // button_details
            // 
            button_details.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_details.Location = new Point(12, 416);
            button_details.Name = "button_details";
            button_details.Size = new Size(146, 26);
            button_details.TabIndex = 5;
            button_details.Text = "Reservation Details";
            button_details.UseVisualStyleBackColor = true;
            button_details.Click += button_details_Click;
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_add.Location = new Point(164, 416);
            button_add.Name = "button_add";
            button_add.Size = new Size(124, 26);
            button_add.TabIndex = 6;
            button_add.Text = "Add Reservation";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // dataGridView_reservations
            // 
            dataGridView_reservations.AllowUserToAddRows = false;
            dataGridView_reservations.AllowUserToDeleteRows = false;
            dataGridView_reservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_reservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_reservations.Location = new Point(12, 6);
            dataGridView_reservations.Name = "dataGridView_reservations";
            dataGridView_reservations.ReadOnly = true;
            dataGridView_reservations.RowHeadersWidth = 46;
            dataGridView_reservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_reservations.Size = new Size(776, 391);
            dataGridView_reservations.TabIndex = 2;
            // 
            // ReservationsDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(button_details);
            Controls.Add(button_add);
            Controls.Add(dataGridView_reservations);
            Name = "ReservationsDataForm";
            Text = "Data of Reservations";
            Load += ReservationsDataForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_reservations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_delete;
        private Button button_update;
        private Button button_details;
        private Button button_add;
        private DataGridView dataGridView_reservations;
    }
}