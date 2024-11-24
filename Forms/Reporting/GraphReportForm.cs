namespace csharp_EZReserve.Forms.Reporting
{
    public partial class GraphReportForm : Form
    {
        // Constants for chart layout
        private const int CHART_PADDING = 40;
        private const int BOTTOM_PADDING = 100; // Extra space for rotated labels
        private const int LEFT_PADDING = 60;    // Space for Y-axis labels
        private readonly Color BAR_COLOR = Color.SteelBlue;
        private List<(string RoomName, int Count)> _currentData = new();
        private DateTime _timeFrom;
        private DateTime _timeTo;


        public GraphReportForm(List<(string RoomName, int Count)> data, DateTime from, DateTime to)
        {
            _currentData = data;
            _timeFrom = from;
            _timeTo = to;
            InitializeComponent();
        }

        private void pictureBox_chart_Paint(object sender, PaintEventArgs e)
        {
            if (!_currentData.Any()) return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Calculate dimensions
            int maxValue = _currentData.Max(x => x.Count);
            int chartWidth = pictureBox_chart.Width - LEFT_PADDING - CHART_PADDING;
            int chartHeight = pictureBox_chart.Height - CHART_PADDING - BOTTOM_PADDING;
            float barWidth = (float)chartWidth / _currentData.Count - 10; // 10px spacing between bars

            // Draw title
            using (Font titleFont = new Font("Arial", 12, FontStyle.Bold))
            {
                string title = $"Četnost rezervací místností ({_timeFrom.ToShortDateString()} - {_timeTo.ToShortDateString()})";
                SizeF titleSize = g.MeasureString(title, titleFont);
                g.DrawString(title, titleFont, Brushes.Black,
                    (pictureBox_chart.Width - titleSize.Width) / 2, CHART_PADDING / 2);
            }

            // Draw Y-axis with labels
            using (Pen axisPen = new Pen(Color.Black, 1))
            {
                g.DrawLine(axisPen, LEFT_PADDING, CHART_PADDING,
                    LEFT_PADDING, chartHeight + CHART_PADDING);

                // Draw Y-axis labels and grid lines
                int yLabelCount = 5;
                using (Font labelFont = new Font("Arial", 8))
                using (Pen gridPen = new Pen(Color.LightGray, 1))
                {
                    for (int i = 0; i <= yLabelCount; i++)
                    {
                        int value = (maxValue * i) / yLabelCount;
                        float y = chartHeight + CHART_PADDING - (chartHeight * i) / yLabelCount;

                        // Draw grid line
                        g.DrawLine(gridPen, LEFT_PADDING, y,
                            LEFT_PADDING + chartWidth, y);

                        // Draw label
                        string label = value.ToString();
                        SizeF labelSize = g.MeasureString(label, labelFont);
                        g.DrawString(label, labelFont, Brushes.Black,
                            LEFT_PADDING - labelSize.Width - 5, y - labelSize.Height / 2);
                    }
                }
            }

            // Draw bars and X-axis labels
            using (Font labelFont = new Font("Arial", 8))
            {
                for (int i = 0; i < _currentData.Count; i++)
                {
                    var (roomName, count) = _currentData[i];
                    float x = LEFT_PADDING + i * (barWidth + 10);
                    float barHeight = ((float)count / maxValue) * chartHeight;
                    float y = chartHeight + CHART_PADDING - barHeight;

                    // Draw bar
                    using (Brush barBrush = new SolidBrush(BAR_COLOR))
                    {
                        g.FillRectangle(barBrush, x, y, barWidth, barHeight);
                    }

                    // Draw value on top of bar
                    string valueLabel = count.ToString();
                    SizeF valueLabelSize = g.MeasureString(valueLabel, labelFont);
                    g.DrawString(valueLabel, labelFont, Brushes.Black,
                        x + (barWidth - valueLabelSize.Width) / 2,
                        y - valueLabelSize.Height - 2);

                    // Draw rotated room name
                    // First measure the text to calculate proper positioning
                    SizeF textSize = g.MeasureString(roomName, labelFont);
                    float rotatedHeight = (float)(Math.Cos(Math.PI / 4) * textSize.Width); // Height when rotated 45 degrees

                    // Calculate the point where the text should start to be centered under the bar
                    float textX = x + (barWidth / 2);
                    float textY = chartHeight + CHART_PADDING + 30; // Small gap after X-axis

                    using (System.Drawing.Drawing2D.Matrix matrix = new System.Drawing.Drawing2D.Matrix())
                    {
                        // Move to position, rotate, then adjust to center
                        matrix.Translate(textX, textY);
                        matrix.Rotate(-45);
                        matrix.Translate(-textSize.Width / 2, 0);

                        g.Transform = matrix;
                        g.DrawString(roomName, labelFont, Brushes.Black, 0, 0);
                        g.ResetTransform();
                    }
                }
            }

            // Draw axes titles
            using (Font axisTitleFont = new Font("Arial", 9, FontStyle.Bold))
            {
                // Y-axis title
                using (System.Drawing.Drawing2D.Matrix matrix = new System.Drawing.Drawing2D.Matrix())
                {
                    matrix.RotateAt(-90, new PointF(20, chartHeight / 2 + CHART_PADDING));
                    g.Transform = matrix;
                    g.DrawString("Počet rezervací", axisTitleFont, Brushes.Black,
                        20, chartHeight / 2 + CHART_PADDING);
                    g.ResetTransform();
                }

                // X-axis title
                g.DrawString("Místnosti", axisTitleFont, Brushes.Black,
                    LEFT_PADDING + chartWidth / 2 - 30,
                    chartHeight + BOTTOM_PADDING);
            }
        }
    }
}
