using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareManV3
{
    public partial class StockTopBar : UserControl
    {
        public StockTopBar()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            // Set the smoothing mode to antialias for better quality
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Define the rectangle dimensions
            int borderRadius = 10; // Adjust the radius as needed
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            // Create a path with rounded corners
            using (GraphicsPath path = CreateRoundedRectanglePath(rect, borderRadius))
            {
                // Define the pen for drawing the border
                using (Pen pen = new Pen(Color.Black, 2)) // Adjust the color and thickness as needed
                {
                    // Draw the rounded rectangle
                    g.DrawPath(pen, path);
                }
            }
        }



        private GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rect.Location, size);
            GraphicsPath path = new GraphicsPath();

            // Top left arc
            path.AddArc(arc, 180, 90);

            // Top right arc
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Bottom right arc
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bottom left arc
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        private void lblToday_Click(object sender, EventArgs e)
        {

        }
    }
}
