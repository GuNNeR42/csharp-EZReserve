namespace csharp_EZReserve.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox_goatware = new PictureBox();
            button_customers = new Button();
            button_reservations = new Button();
            button_reporting = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_goatware).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_goatware
            // 
            pictureBox_goatware.Dock = DockStyle.Top;
            pictureBox_goatware.Image = Resources.goatware;
            pictureBox_goatware.Location = new Point(0, 0);
            pictureBox_goatware.Name = "pictureBox_goatware";
            pictureBox_goatware.Size = new Size(800, 256);
            pictureBox_goatware.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_goatware.TabIndex = 0;
            pictureBox_goatware.TabStop = false;
            // 
            // button_customers
            // 
            button_customers.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_customers.Location = new Point(290, 308);
            button_customers.Name = "button_customers";
            button_customers.Size = new Size(225, 26);
            button_customers.TabIndex = 1;
            button_customers.Text = "Customers";
            button_customers.UseVisualStyleBackColor = true;
            // 
            // button_reservations
            // 
            button_reservations.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_reservations.Location = new Point(290, 340);
            button_reservations.Name = "button_reservations";
            button_reservations.Size = new Size(225, 26);
            button_reservations.TabIndex = 1;
            button_reservations.Text = "Reservations";
            button_reservations.UseVisualStyleBackColor = true;
            // 
            // button_reporting
            // 
            button_reporting.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_reporting.Location = new Point(290, 372);
            button_reporting.Name = "button_reporting";
            button_reporting.Size = new Size(225, 26);
            button_reporting.TabIndex = 1;
            button_reporting.Text = "Reporting";
            button_reporting.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_reporting);
            Controls.Add(button_reservations);
            Controls.Add(button_customers);
            Controls.Add(pictureBox_goatware);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EZReserve";
            ((System.ComponentModel.ISupportInitialize)pictureBox_goatware).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_goatware;
        private Button button_customers;
        private Button button_reservations;
        private Button button_reporting;
    }
}
