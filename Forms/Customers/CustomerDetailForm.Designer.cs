namespace csharp_EZReserve.Forms.Customers
{
    partial class CustomerDetailForm
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
            label_postalCode = new Label();
            label_city = new Label();
            label_streetAddress = new Label();
            label_email = new Label();
            label_lastName = new Label();
            label_firstName = new Label();
            dataGridView_customerReservations = new DataGridView();
            label_firstName_data = new Label();
            label_lastName_data = new Label();
            label_email_data = new Label();
            label_streetAddress_data = new Label();
            label_city_data = new Label();
            label_postalCode_data = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_customerReservations).BeginInit();
            SuspendLayout();
            // 
            // label_postalCode
            // 
            label_postalCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_postalCode.AutoSize = true;
            label_postalCode.Location = new Point(361, 79);
            label_postalCode.Name = "label_postalCode";
            label_postalCode.Size = new Size(81, 19);
            label_postalCode.TabIndex = 13;
            label_postalCode.Text = "Postal code:";
            label_postalCode.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_city
            // 
            label_city.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_city.AutoSize = true;
            label_city.Location = new Point(404, 47);
            label_city.Name = "label_city";
            label_city.Size = new Size(36, 19);
            label_city.TabIndex = 14;
            label_city.Text = "City:";
            label_city.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_streetAddress
            // 
            label_streetAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_streetAddress.AutoSize = true;
            label_streetAddress.Location = new Point(344, 15);
            label_streetAddress.Name = "label_streetAddress";
            label_streetAddress.Size = new Size(99, 19);
            label_streetAddress.TabIndex = 15;
            label_streetAddress.Text = "Street address:";
            label_streetAddress.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new Point(65, 79);
            label_email.Name = "label_email";
            label_email.Size = new Size(44, 19);
            label_email.TabIndex = 16;
            label_email.Text = "Email:";
            label_email.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_lastName
            // 
            label_lastName.AutoSize = true;
            label_lastName.Location = new Point(36, 47);
            label_lastName.Name = "label_lastName";
            label_lastName.Size = new Size(75, 19);
            label_lastName.TabIndex = 17;
            label_lastName.Text = "Last name:";
            label_lastName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_firstName
            // 
            label_firstName.AutoSize = true;
            label_firstName.Location = new Point(36, 15);
            label_firstName.Name = "label_firstName";
            label_firstName.Size = new Size(76, 19);
            label_firstName.TabIndex = 18;
            label_firstName.Text = "First name:";
            label_firstName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dataGridView_customerReservations
            // 
            dataGridView_customerReservations.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_customerReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_customerReservations.Location = new Point(12, 122);
            dataGridView_customerReservations.Name = "dataGridView_customerReservations";
            dataGridView_customerReservations.ReadOnly = true;
            dataGridView_customerReservations.RowHeadersWidth = 46;
            dataGridView_customerReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_customerReservations.Size = new Size(659, 222);
            dataGridView_customerReservations.TabIndex = 19;
            // 
            // label_firstName_data
            // 
            label_firstName_data.AutoSize = true;
            label_firstName_data.Location = new Point(116, 15);
            label_firstName_data.Name = "label_firstName_data";
            label_firstName_data.Size = new Size(73, 19);
            label_firstName_data.TabIndex = 18;
            label_firstName_data.Text = "First name";
            label_firstName_data.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_lastName_data
            // 
            label_lastName_data.AutoSize = true;
            label_lastName_data.Location = new Point(117, 47);
            label_lastName_data.Name = "label_lastName_data";
            label_lastName_data.Size = new Size(72, 19);
            label_lastName_data.TabIndex = 17;
            label_lastName_data.Text = "Last name";
            label_lastName_data.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_email_data
            // 
            label_email_data.AutoSize = true;
            label_email_data.Location = new Point(117, 79);
            label_email_data.Name = "label_email_data";
            label_email_data.Size = new Size(41, 19);
            label_email_data.TabIndex = 16;
            label_email_data.Text = "Email";
            label_email_data.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_streetAddress_data
            // 
            label_streetAddress_data.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_streetAddress_data.AutoSize = true;
            label_streetAddress_data.Location = new Point(457, 15);
            label_streetAddress_data.Name = "label_streetAddress_data";
            label_streetAddress_data.Size = new Size(96, 19);
            label_streetAddress_data.TabIndex = 15;
            label_streetAddress_data.Text = "Street address";
            label_streetAddress_data.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_city_data
            // 
            label_city_data.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_city_data.AutoSize = true;
            label_city_data.Location = new Point(457, 47);
            label_city_data.Name = "label_city_data";
            label_city_data.Size = new Size(33, 19);
            label_city_data.TabIndex = 14;
            label_city_data.Text = "City";
            label_city_data.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_postalCode_data
            // 
            label_postalCode_data.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_postalCode_data.AutoSize = true;
            label_postalCode_data.Location = new Point(457, 79);
            label_postalCode_data.Name = "label_postalCode_data";
            label_postalCode_data.Size = new Size(78, 19);
            label_postalCode_data.TabIndex = 13;
            label_postalCode_data.Text = "Postal code";
            label_postalCode_data.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CustomerDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 356);
            Controls.Add(dataGridView_customerReservations);
            Controls.Add(label_postalCode_data);
            Controls.Add(label_postalCode);
            Controls.Add(label_city_data);
            Controls.Add(label_city);
            Controls.Add(label_streetAddress_data);
            Controls.Add(label_streetAddress);
            Controls.Add(label_email_data);
            Controls.Add(label_lastName_data);
            Controls.Add(label_email);
            Controls.Add(label_firstName_data);
            Controls.Add(label_lastName);
            Controls.Add(label_firstName);
            MinimumSize = new Size(700, 400);
            Name = "CustomerDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ShowCustomerDetailsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView_customerReservations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_postalCode;
        private Label label_city;
        private Label label_streetAddress;
        private Label label_email;
        private Label label_lastName;
        private Label label_firstName;
        private DataGridView dataGridView_customerReservations;
        private Label label_firstName_data;
        private Label label_lastName_data;
        private Label label_email_data;
        private Label label_streetAddress_data;
        private Label label_city_data;
        private Label label_postalCode_data;
    }
}