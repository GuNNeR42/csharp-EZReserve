namespace csharp_EZReserve.Forms.Customers
{
    partial class CustomersDataForm
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
            dataGridView_customers = new DataGridView();
            button_add = new Button();
            button_update = new Button();
            button_delete = new Button();
            button_details = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_customers).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_customers
            // 
            dataGridView_customers.AllowUserToAddRows = false;
            dataGridView_customers.AllowUserToDeleteRows = false;
            dataGridView_customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_customers.Location = new Point(12, 0);
            dataGridView_customers.Name = "dataGridView_customers";
            dataGridView_customers.ReadOnly = true;
            dataGridView_customers.RowHeadersWidth = 46;
            dataGridView_customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_customers.Size = new Size(776, 391);
            dataGridView_customers.TabIndex = 0;
            // 
            // button_add
            // 
            button_add.Location = new Point(142, 412);
            button_add.Name = "button_add";
            button_add.Size = new Size(124, 26);
            button_add.TabIndex = 1;
            button_add.Text = "Add Customer";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_update
            // 
            button_update.Location = new Point(272, 412);
            button_update.Name = "button_update";
            button_update.Size = new Size(139, 26);
            button_update.TabIndex = 1;
            button_update.Text = "Update Customer";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(417, 412);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(139, 26);
            button_delete.TabIndex = 1;
            button_delete.Text = "Delete Customer";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_details
            // 
            button_details.Location = new Point(12, 412);
            button_details.Name = "button_details";
            button_details.Size = new Size(124, 26);
            button_details.TabIndex = 1;
            button_details.Text = "Customer Details";
            button_details.UseVisualStyleBackColor = true;
            button_details.Click += button_details_Click;
            // 
            // CustomersDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(button_details);
            Controls.Add(button_add);
            Controls.Add(dataGridView_customers);
            Name = "CustomersDataForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Data of Customers";
            Load += CustomersDataForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_customers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_customers;
        private Button button_add;
        private Button button_update;
        private Button button_delete;
        private Button button_details;
    }
}