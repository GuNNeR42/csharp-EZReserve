namespace csharp_EZReserve.Forms.Customers
{
    partial class AddUpdateCustomerForm
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
            textBox_firstName = new TextBox();
            textBox_lastName = new TextBox();
            textBox_email = new TextBox();
            textBox_streetAddress = new TextBox();
            textBox_city = new TextBox();
            textBox_postalCode = new TextBox();
            label_firstName = new Label();
            label_lastName = new Label();
            label_email = new Label();
            label_streetAddress = new Label();
            label_city = new Label();
            label_postalCode = new Label();
            button_save = new Button();
            errorProvider_validate = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider_validate).BeginInit();
            SuspendLayout();
            // 
            // textBox_firstName
            // 
            textBox_firstName.Location = new Point(107, 36);
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.Size = new Size(209, 26);
            textBox_firstName.TabIndex = 0;
            textBox_firstName.Validating += textBox_firstName_Validating;
            // 
            // textBox_lastName
            // 
            textBox_lastName.Location = new Point(107, 68);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.Size = new Size(209, 26);
            textBox_lastName.TabIndex = 1;
            textBox_lastName.Validating += textBox_lastName_Validating;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(107, 100);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(209, 26);
            textBox_email.TabIndex = 2;
            textBox_email.Validating += textBox_email_Validating;
            // 
            // textBox_streetAddress
            // 
            textBox_streetAddress.Location = new Point(107, 145);
            textBox_streetAddress.Name = "textBox_streetAddress";
            textBox_streetAddress.Size = new Size(209, 26);
            textBox_streetAddress.TabIndex = 3;
            textBox_streetAddress.Validating += textBox_streetAddress_Validating;
            // 
            // textBox_city
            // 
            textBox_city.Location = new Point(107, 177);
            textBox_city.Name = "textBox_city";
            textBox_city.Size = new Size(209, 26);
            textBox_city.TabIndex = 4;
            textBox_city.Validating += textBox_city_Validating;
            // 
            // textBox_postalCode
            // 
            textBox_postalCode.Location = new Point(107, 209);
            textBox_postalCode.Name = "textBox_postalCode";
            textBox_postalCode.Size = new Size(209, 26);
            textBox_postalCode.TabIndex = 5;
            textBox_postalCode.Validating += textBox_postalCode_Validating;
            // 
            // label_firstName
            // 
            label_firstName.AutoSize = true;
            label_firstName.Location = new Point(28, 39);
            label_firstName.Name = "label_firstName";
            label_firstName.Size = new Size(76, 19);
            label_firstName.TabIndex = 6;
            label_firstName.Text = "First name:";
            label_firstName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_lastName
            // 
            label_lastName.AutoSize = true;
            label_lastName.Location = new Point(28, 71);
            label_lastName.Name = "label_lastName";
            label_lastName.Size = new Size(75, 19);
            label_lastName.TabIndex = 6;
            label_lastName.Text = "Last name:";
            label_lastName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new Point(57, 103);
            label_email.Name = "label_email";
            label_email.Size = new Size(44, 19);
            label_email.TabIndex = 6;
            label_email.Text = "Email:";
            label_email.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_streetAddress
            // 
            label_streetAddress.AutoSize = true;
            label_streetAddress.Location = new Point(5, 148);
            label_streetAddress.Name = "label_streetAddress";
            label_streetAddress.Size = new Size(99, 19);
            label_streetAddress.TabIndex = 6;
            label_streetAddress.Text = "Street address:";
            label_streetAddress.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_city
            // 
            label_city.AutoSize = true;
            label_city.Location = new Point(65, 180);
            label_city.Name = "label_city";
            label_city.Size = new Size(36, 19);
            label_city.TabIndex = 6;
            label_city.Text = "City:";
            label_city.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_postalCode
            // 
            label_postalCode.AutoSize = true;
            label_postalCode.Location = new Point(22, 212);
            label_postalCode.Name = "label_postalCode";
            label_postalCode.Size = new Size(81, 19);
            label_postalCode.TabIndex = 6;
            label_postalCode.Text = "Postal code:";
            label_postalCode.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_save.Location = new Point(12, 259);
            button_save.Name = "button_save";
            button_save.Size = new Size(320, 26);
            button_save.TabIndex = 7;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // errorProvider_validate
            // 
            errorProvider_validate.ContainerControl = this;
            // 
            // AddUpdateCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 297);
            Controls.Add(button_save);
            Controls.Add(label_postalCode);
            Controls.Add(label_city);
            Controls.Add(label_streetAddress);
            Controls.Add(label_email);
            Controls.Add(label_lastName);
            Controls.Add(label_firstName);
            Controls.Add(textBox_postalCode);
            Controls.Add(textBox_city);
            Controls.Add(textBox_streetAddress);
            Controls.Add(textBox_email);
            Controls.Add(textBox_lastName);
            Controls.Add(textBox_firstName);
            MaximumSize = new Size(362, 341);
            MinimumSize = new Size(362, 341);
            Name = "AddUpdateCustomerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddCustomerForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider_validate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_firstName;
        private TextBox textBox_lastName;
        private TextBox textBox_email;
        private TextBox textBox_streetAddress;
        private TextBox textBox_city;
        private TextBox textBox_postalCode;
        private Label label_firstName;
        private Label label_lastName;
        private Label label_email;
        private Label label_streetAddress;
        private Label label_city;
        private Label label_postalCode;
        private Button button_save;
        private ErrorProvider errorProvider_validate;
    }
}