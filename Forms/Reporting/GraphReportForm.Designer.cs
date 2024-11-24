namespace csharp_EZReserve.Forms.Reporting
{
    partial class GraphReportForm
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
            pictureBox_chart = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_chart).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_chart
            // 
            pictureBox_chart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox_chart.Location = new Point(0, 0);
            pictureBox_chart.Name = "pictureBox_chart";
            pictureBox_chart.Size = new Size(782, 556);
            pictureBox_chart.TabIndex = 0;
            pictureBox_chart.TabStop = false;
            pictureBox_chart.Paint += pictureBox_chart_Paint;
            // 
            // GraphReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 556);
            Controls.Add(pictureBox_chart);
            MinimumSize = new Size(800, 600);
            Name = "GraphReportForm";
            Text = "GraphReportForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox_chart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_chart;
    }
}