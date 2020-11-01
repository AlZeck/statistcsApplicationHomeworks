using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartsTask9App
{
    class ScatterPlot : Panel, IChart
    {
        public static int HEIGHT = 600;
        public static int WIDTH = 600;


        int MinX;
        int RangeX;
        int MinY;
        int RangeY;
        float AvgX;
        float AvgY;

        List<PointF> Dist;

        public ScatterPlot(List<PointF> dist, int minx, int rangex, int miny, int rangey, float avgx, float avgy)
        {
            Dist = dist;

            MinX = minx;
            MinY = miny;
            RangeX = rangex;
            RangeY = rangey;

            AvgX = avgx;
            AvgY = avgy;
            
            base.Width = WIDTH;
            base.Height = HEIGHT;
            base.BorderStyle = BorderStyle.FixedSingle;
            base.Paint += new PaintEventHandler(on_paint);
            base.MouseDown += new MouseEventHandler(chartMove_MouseDown);
            base.MouseMove += new MouseEventHandler(chartMove_MouseMove);
        }

        public void on_paint(object sender, PaintEventArgs e)
        {
            UpdateContent();
        }

        public void UpdateContent()
        {
            Graphics graphics = base.CreateGraphics();
            graphics.Clear(Color.White);
            float x;
            float y;
            for (int i = 0; i < 10; i++) // Create Grid
            {
                x = (float)i / 10 * base.Width;
                y = (float)i / 10 * base.Height;

                graphics.DrawLine(new Pen(Brushes.Gray), 0, y, base.Width, y);
                graphics.DrawLine(new Pen(Brushes.Gray), x, 0, x, base.Height);
            }

            foreach (PointF p in Dist) // Set Points
            {
                x = (float)(p.X - MinX) / RangeX * base.Width;
                y = base.Height - (float)(p.Y - MinY) / RangeY * base.Height;

                graphics.FillEllipse(Brushes.Black, x, y, 5, 5);
            }
            

            // Add average
            x = (float)(AvgX - MinX) / RangeX * base.Width;
            y = base.Height - (float)(AvgY - MinY) / RangeY * base.Height;

            graphics.DrawLine(new Pen(Brushes.Indigo, 2), 0, y, base.Width, y);
            graphics.DrawLine(new Pen(Brushes.Indigo, 2), x, 0, x, base.Height);
        }

        Point PanelMouseDownLocation;
        private void chartMove_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PanelMouseDownLocation = e.Location;
            }
        }

        private void chartMove_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {                
                this.Left += e.X - PanelMouseDownLocation.X;
                this.Top += e.Y - PanelMouseDownLocation.Y;
            }
        }

    }
}
