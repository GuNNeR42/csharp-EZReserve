namespace csharp_EZReserve.Forms.Reporting
{
    partial class ReportingForm
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
            button_exportCsv = new Button();
            button_exportXlsx = new Button();
            button_graph = new Button();
            dateTimePicker_toTime = new DateTimePicker();
            dateTimePicker_fromTime = new DateTimePicker();
            label_to = new Label();
            label_from = new Label();
            dateTimePicker_toDate = new DateTimePicker();
            dateTimePicker_fromDate = new DateTimePicker();
            SuspendLayout();
            // 
            // button_exportCsv
            // 
            button_exportCsv.Location = new Point(12, 198);
            button_exportCsv.Name = "button_exportCsv";
            button_exportCsv.Size = new Size(365, 26);
            button_exportCsv.TabIndex = 3;
            button_exportCsv.Text = "Exportovat do CSV";
            button_exportCsv.UseVisualStyleBackColor = true;
            button_exportCsv.Click += button_exportCsv_Click;
            // 
            // button_exportXlsx
            // 
            button_exportXlsx.Location = new Point(12, 230);
            button_exportXlsx.Name = "button_exportXlsx";
            button_exportXlsx.Size = new Size(365, 26);
            button_exportXlsx.TabIndex = 3;
            button_exportXlsx.Text = "Exportovat do Excelu";
            button_exportXlsx.UseVisualStyleBackColor = true;
            button_exportXlsx.Click += button_exportXlsx_Click;
            // 
            // button_graph
            // 
            button_graph.Location = new Point(12, 262);
            button_graph.Name = "button_graph";
            button_graph.Size = new Size(365, 26);
            button_graph.TabIndex = 3;
            button_graph.Text = "Grafický report";
            button_graph.UseVisualStyleBackColor = true;
            button_graph.Click += button_graph_Click;
            // 
            // dateTimePicker_toTime
            // 
            dateTimePicker_toTime.CustomFormat = "HH:mm";
            dateTimePicker_toTime.Format = DateTimePickerFormat.Custom;
            dateTimePicker_toTime.Location = new Point(279, 43);
            dateTimePicker_toTime.Name = "dateTimePicker_toTime";
            dateTimePicker_toTime.ShowUpDown = true;
            dateTimePicker_toTime.Size = new Size(98, 26);
            dateTimePicker_toTime.TabIndex = 11;
            // 
            // dateTimePicker_fromTime
            // 
            dateTimePicker_fromTime.CustomFormat = "HH:mm";
            dateTimePicker_fromTime.Format = DateTimePickerFormat.Custom;
            dateTimePicker_fromTime.Location = new Point(279, 12);
            dateTimePicker_fromTime.Name = "dateTimePicker_fromTime";
            dateTimePicker_fromTime.ShowUpDown = true;
            dateTimePicker_fromTime.Size = new Size(98, 26);
            dateTimePicker_fromTime.TabIndex = 7;
            // 
            // label_to
            // 
            label_to.AutoSize = true;
            label_to.Location = new Point(25, 50);
            label_to.Name = "label_to";
            label_to.Size = new Size(26, 19);
            label_to.TabIndex = 8;
            label_to.Text = "To:";
            label_to.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_from
            // 
            label_from.AutoSize = true;
            label_from.Location = new Point(7, 15);
            label_from.Name = "label_from";
            label_from.Size = new Size(44, 19);
            label_from.TabIndex = 9;
            label_from.Text = "From:";
            label_from.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePicker_toDate
            // 
            dateTimePicker_toDate.Location = new Point(61, 44);
            dateTimePicker_toDate.Name = "dateTimePicker_toDate";
            dateTimePicker_toDate.Size = new Size(212, 26);
            dateTimePicker_toDate.TabIndex = 10;
            // 
            // dateTimePicker_fromDate
            // 
            dateTimePicker_fromDate.Location = new Point(61, 12);
            dateTimePicker_fromDate.Name = "dateTimePicker_fromDate";
            dateTimePicker_fromDate.Size = new Size(212, 26);
            dateTimePicker_fromDate.TabIndex = 6;
            // 
            // ReportingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 300);
            Controls.Add(dateTimePicker_toTime);
            Controls.Add(dateTimePicker_fromTime);
            Controls.Add(label_to);
            Controls.Add(label_from);
            Controls.Add(dateTimePicker_toDate);
            Controls.Add(dateTimePicker_fromDate);
            Controls.Add(button_graph);
            Controls.Add(button_exportXlsx);
            Controls.Add(button_exportCsv);
            MinimumSize = new Size(407, 344);
            Name = "ReportingForm";
            Text = "ReportingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_exportCsv;
        private Button button_exportXlsx;
        private Button button_graph;
        private DateTimePicker dateTimePicker_toTime;
        private DateTimePicker dateTimePicker_fromTime;
        private Label label_to;
        private Label label_from;
        private DateTimePicker dateTimePicker_toDate;
        private DateTimePicker dateTimePicker_fromDate;
    }
}