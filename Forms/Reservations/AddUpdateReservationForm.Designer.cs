namespace csharp_EZReserve.Forms.Reservations
{
    partial class AddUpdateReservationForm
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
            components = new System.ComponentModel.Container();
            comboBox_customers = new ComboBox();
            comboBox_rooms = new ComboBox();
            dateTimePicker_fromDate = new DateTimePicker();
            dateTimePicker_toDate = new DateTimePicker();
            label_customer = new Label();
            label_room = new Label();
            label_from = new Label();
            label_to = new Label();
            button_save = new Button();
            errorProvider_validate = new ErrorProvider(components);
            dateTimePicker_fromTime = new DateTimePicker();
            dateTimePicker_toTime = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)errorProvider_validate).BeginInit();
            SuspendLayout();
            // 
            // comboBox_customers
            // 
            comboBox_customers.FormattingEnabled = true;
            comboBox_customers.Location = new Point(90, 27);
            comboBox_customers.Name = "comboBox_customers";
            comboBox_customers.Size = new Size(329, 27);
            comboBox_customers.TabIndex = 0;
            comboBox_customers.Validating += comboBox_customers_Validating;
            // 
            // comboBox_rooms
            // 
            comboBox_rooms.FormattingEnabled = true;
            comboBox_rooms.Location = new Point(90, 60);
            comboBox_rooms.Name = "comboBox_rooms";
            comboBox_rooms.Size = new Size(329, 27);
            comboBox_rooms.TabIndex = 1;
            comboBox_rooms.Validating += comboBox_rooms_Validating;
            // 
            // dateTimePicker_fromDate
            // 
            dateTimePicker_fromDate.Location = new Point(90, 93);
            dateTimePicker_fromDate.Name = "dateTimePicker_fromDate";
            dateTimePicker_fromDate.Size = new Size(225, 26);
            dateTimePicker_fromDate.TabIndex = 2;
            // 
            // dateTimePicker_toDate
            // 
            dateTimePicker_toDate.Location = new Point(90, 125);
            dateTimePicker_toDate.Name = "dateTimePicker_toDate";
            dateTimePicker_toDate.Size = new Size(225, 26);
            dateTimePicker_toDate.TabIndex = 4;
            // 
            // label_customer
            // 
            label_customer.AutoSize = true;
            label_customer.Location = new Point(12, 30);
            label_customer.Name = "label_customer";
            label_customer.Size = new Size(72, 19);
            label_customer.TabIndex = 3;
            label_customer.Text = "Customer:";
            label_customer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_room
            // 
            label_room.AutoSize = true;
            label_room.Location = new Point(36, 63);
            label_room.Name = "label_room";
            label_room.Size = new Size(48, 19);
            label_room.TabIndex = 3;
            label_room.Text = "Room:";
            label_room.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_from
            // 
            label_from.AutoSize = true;
            label_from.Location = new Point(40, 96);
            label_from.Name = "label_from";
            label_from.Size = new Size(44, 19);
            label_from.TabIndex = 3;
            label_from.Text = "From:";
            label_from.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_to
            // 
            label_to.AutoSize = true;
            label_to.Location = new Point(58, 131);
            label_to.Name = "label_to";
            label_to.Size = new Size(26, 19);
            label_to.TabIndex = 3;
            label_to.Text = "To:";
            label_to.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_save.Location = new Point(12, 187);
            button_save.Name = "button_save";
            button_save.Size = new Size(419, 26);
            button_save.TabIndex = 100;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // errorProvider_validate
            // 
            errorProvider_validate.ContainerControl = this;
            // 
            // dateTimePicker_fromTime
            // 
            dateTimePicker_fromTime.CustomFormat = "HH:mm";
            dateTimePicker_fromTime.Format = DateTimePickerFormat.Custom;
            dateTimePicker_fromTime.Location = new Point(321, 93);
            dateTimePicker_fromTime.Name = "dateTimePicker_fromTime";
            dateTimePicker_fromTime.ShowUpDown = true;
            dateTimePicker_fromTime.Size = new Size(98, 26);
            dateTimePicker_fromTime.TabIndex = 3;
            dateTimePicker_fromTime.Validating += dateTimePicker_fromTime_Validating;
            // 
            // dateTimePicker_toTime
            // 
            dateTimePicker_toTime.CustomFormat = "HH:mm";
            dateTimePicker_toTime.Format = DateTimePickerFormat.Custom;
            dateTimePicker_toTime.Location = new Point(321, 124);
            dateTimePicker_toTime.Name = "dateTimePicker_toTime";
            dateTimePicker_toTime.ShowUpDown = true;
            dateTimePicker_toTime.Size = new Size(98, 26);
            dateTimePicker_toTime.TabIndex = 5;
            dateTimePicker_toTime.Validating += dateTimePicker_toTime_Validating;
            // 
            // AddUpdateReservationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 225);
            Controls.Add(dateTimePicker_toTime);
            Controls.Add(dateTimePicker_fromTime);
            Controls.Add(button_save);
            Controls.Add(label_to);
            Controls.Add(label_from);
            Controls.Add(label_room);
            Controls.Add(label_customer);
            Controls.Add(dateTimePicker_toDate);
            Controls.Add(dateTimePicker_fromDate);
            Controls.Add(comboBox_rooms);
            Controls.Add(comboBox_customers);
            MinimumSize = new Size(373, 269);
            Name = "AddUpdateReservationForm";
            Text = "AddUpdateReservationForm";
            Load += AddUpdateReservationForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider_validate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_customers;
        private ComboBox comboBox_rooms;
        private DateTimePicker dateTimePicker_fromDate;
        private DateTimePicker dateTimePicker_toDate;
        private Label label_customer;
        private Label label_room;
        private Label label_from;
        private Label label_to;
        private Button button_save;
        private ErrorProvider errorProvider_validate;
        private DateTimePicker dateTimePicker_fromTime;
        private DateTimePicker dateTimePicker_toTime;
    }
}