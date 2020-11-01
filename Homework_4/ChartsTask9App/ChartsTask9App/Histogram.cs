using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartsTask9App
{
    class Histogram : Panel, IChart
    {
        public static int HEIGHT = 100;
        public static int WIDTH = 600;
        Distribution Dist;
        private Orientation O;

        public Histogram(Distribution dist, Orientation o)
        {
            O = o;
            Dist = dist;
            if (o == Orientation.Vertical)
            {
                base.Width = HEIGHT;
                base.Height = WIDTH;
            }
            else
            {
                base.Width = WIDTH;
                base.Height = HEIGHT;
            }
            base.DoubleClick += new EventHandler(Rotate);
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
            Graphics graph = base.CreateGraphics();
            graph.Clear(Color.White);
            Pen pen = new Pen(Brushes.White, 2);
            // graph.DrawRectangle(new Pen(Brushes.Green), 0, 0, base.Width, base.Height);
            int max = Dist.Dist.Values.ToList().OrderBy(x => x.Count).Last().Count + 5;

            List<Interval> keys = Dist.Dist.Keys.ToList<Interval>();
            if (O == Orientation.Vertical)
            {
                int bar_width = base.Height / keys.Count;
                for (int i = 0; i < 10; i++) // Create Grid
                {
                    float x = (float)i / 10 * base.Width;
                    graph.DrawLine(new Pen(Brushes.Gray), x, 0, x, base.Height);
                }
                for (int i = 0; i < keys.Count; i++) // Add Blocks
                {
                    int freq = (int)((float)Dist.Dist[keys[i]].Count / max * base.Width);
                    // x,y,width, height
                    graph.FillRectangle(Brushes.LimeGreen, 0, (keys.Count - 1 - i) * bar_width, (float)freq, bar_width);

                    // Add bloch avg 
                    float block_avg = (keys.Count - i) * bar_width - (float)( Dist.Dist[keys[i]].Avg - keys[i].Start )/Dist.Step * bar_width;

                    graph.DrawLine(new Pen(Brushes.Green, 2), 0, block_avg, freq, block_avg);

                    graph.DrawRectangle(pen, 0, (keys.Count - 1 - i) * bar_width, (float)freq, bar_width);
                }

                // Add Avg 
                float conv_avg = base.Height - (float)(Dist.Avg) / Dist.End * base.Height;
                graph.DrawLine(new Pen(Brushes.Indigo, 2), 0, conv_avg, base.Width, conv_avg);
            }
            else
            {
                int bar_width = base.Width / keys.Count;
                
                for (int i = 0; i < 10; i++) // Create Grid
                {
                    float y = (float)i / 10 * base.Height;
                    graph.DrawLine(new Pen(Brushes.Gray), 0, y, base.Width, y);
                }

                for (int i = 0; i < keys.Count; i++) // Add Blocks
                {
                    int freq = (int)((float)Dist.Dist[keys[i]].Count / max * base.Height);

                    // x,y,width, height
                    graph.FillRectangle(Brushes.LimeGreen, i * bar_width, base.Height - freq, bar_width, freq);

                    // Add bloch avg 
                    float block_avg =  i * bar_width + (float)(Dist.Dist[keys[i]].Avg - keys[i].Start) / Dist.Step * bar_width;

                    graph.DrawLine(new Pen(Brushes.Green, 2),block_avg, base.Height - freq, block_avg, base.Height);

                    graph.DrawRectangle(pen, i * bar_width, base.Height - freq, bar_width, freq);
                }

                // Add Avg
                float conv_avg = (float)(Dist.Avg) / Dist.End * base.Width;
                graph.DrawLine(new Pen(Brushes.Indigo, 2), conv_avg, 0, conv_avg, base.Height);
            }
        }


        public void Rotate(object sender, EventArgs e)
        {
            int widht = base.Width;
            int height = base.Height;
            base.Width = height;
            base.Height = widht;
            if (O == Orientation.Horizontal)
                O = Orientation.Vertical;
            else
                O = Orientation.Horizontal;
            UpdateContent();
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

            if (e.Button == MouseButtons.Left && sender is Panel)
            {
                Panel panel = (Panel)sender;
                panel.Left += e.X - PanelMouseDownLocation.X;
                panel.Top += e.Y - PanelMouseDownLocation.Y;
            }
        }
    }

}
