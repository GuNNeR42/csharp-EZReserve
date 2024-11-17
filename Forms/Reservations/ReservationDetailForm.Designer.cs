namespace csharp_EZReserve.Forms.Reservations
{
    partial class ReservationDetailForm
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
            label_to_data = new Label();
            label_to = new Label();
            label_from_data = new Label();
            label_from = new Label();
            label_customer_data = new Label();
            label_room_data = new Label();
            label_customer = new Label();
            label_room = new Label();
            button_customerDetails = new Button();
            SuspendLayout();
            // 
            // label_to_data
            // 
            label_to_data.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_to_data.AutoSize = true;
            label_to_data.Location = new Point(385, 41);
            label_to_data.Name = "label_to_data";
            label_to_data.Size = new Size(23, 19);
            label_to_data.TabIndex = 21;
            label_to_data.Text = "To";
            label_to_data.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_to
            // 
            label_to.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_to.AutoSize = true;
            label_to.Location = new Point(223, 41);
            label_to.Name = "label_to";
            label_to.Size = new Size(84, 19);
            label_to.TabIndex = 22;
            label_to.Text = "Reserved to:";
            label_to.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_from_data
            // 
            label_from_data.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_from_data.AutoSize = true;
            label_from_data.Location = new Point(385, 9);
            label_from_data.Name = "label_from_data";
            label_from_data.Size = new Size(41, 19);
            label_from_data.TabIndex = 23;
            label_from_data.Text = "From";
            label_from_data.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_from
            // 
            label_from.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_from.AutoSize = true;
            label_from.Location = new Point(207, 9);
            label_from.Name = "label_from";
            label_from.Size = new Size(100, 19);
            label_from.TabIndex = 24;
            label_from.Text = "Reserved from:";
            label_from.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_customer_data
            // 
            label_customer_data.AutoSize = true;
            label_customer_data.Location = new Point(93, 41);
            label_customer_data.Name = "label_customer_data";
            label_customer_data.Size = new Size(69, 19);
            label_customer_data.TabIndex = 27;
            label_customer_data.Text = "Customer";
            label_customer_data.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_room_data
            // 
            label_room_data.AutoSize = true;
            label_room_data.Location = new Point(92, 9);
            label_room_data.Name = "label_room_data";
            label_room_data.Size = new Size(45, 19);
            label_room_data.TabIndex = 29;
            label_room_data.Text = "Room";
            label_room_data.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_customer
            // 
            label_customer.AutoSize = true;
            label_customer.Location = new Point(13, 41);
            label_customer.Name = "label_customer";
            label_customer.Size = new Size(72, 19);
            label_customer.TabIndex = 28;
            label_customer.Text = "Customer:";
            label_customer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_room
            // 
            label_room.AutoSize = true;
            label_room.Location = new Point(37, 9);
            label_room.Name = "label_room";
            label_room.Size = new Size(48, 19);
            label_room.TabIndex = 30;
            label_room.Text = "Room:";
            label_room.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button_customerDetails
            // 
            button_customerDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_customerDetails.Location = new Point(13, 113);
            button_customerDetails.Name = "button_customerDetails";
            button_customerDetails.Size = new Size(468, 26);
            button_customerDetails.TabIndex = 31;
            button_customerDetails.Text = "Full customer details";
            button_customerDetails.UseVisualStyleBackColor = true;
            button_customerDetails.Click += button_customerDetails_Click;
            // 
            // ReservationDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 151);
            Controls.Add(button_customerDetails);
            Controls.Add(label_to_data);
            Controls.Add(label_to);
            Controls.Add(label_from_data);
            Controls.Add(label_from);
            Controls.Add(label_customer_data);
            Controls.Add(label_room_data);
            Controls.Add(label_customer);
            Controls.Add(label_room);
            MinimumSize = new Size(432, 195);
            Name = "ReservationDetailForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ReservationDetailForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_to_data;
        private Label label_to;
        private Label label_from_data;
        private Label label_from;
        private Label label_customer_data;
        private Label label_room_data;
        private Label label_customer;
        private Label label_room;
        private Button button_customerDetails;
    }
}