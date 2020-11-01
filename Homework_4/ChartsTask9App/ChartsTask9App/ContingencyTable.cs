using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartsTask9App
{
    class ContingencyTable : Panel, IChart
    {
        BivariateDistribution Dist;

        Pen pen;
        Font font;
        Font headerFont;

        SizeF lenght;

        public ContingencyTable(BivariateDistribution dist)
        {
            Dist = dist;
            Graphics g = base.CreateGraphics();
            pen = new Pen(Brushes.Black);
            font = new Font(FontFamily.GenericMonospace, 12.0f);
            headerFont = new Font(FontFamily.GenericMonospace, 12.0f, FontStyle.Bold);
            SizeF max_lenght_x = g.MeasureString(Dist.IntX.Last().ToString(), headerFont);
            SizeF max_lenght_y = g.MeasureString(Dist.IntY.Last().ToString(), headerFont);

            SizeF Marginal_lenght = g.MeasureString("Marginal X", font);

            lenght = (max_lenght_x.Width < max_lenght_y.Width) ? max_lenght_y : max_lenght_x;
            lenght = (Marginal_lenght.Width < max_lenght_y.Width) ? max_lenght_y : Marginal_lenght;

            base.Height = 5 + (int) lenght.Height * (Dist.IntY.Count + 2);
            base.Width = 5 + (int) lenght.Width * (Dist.IntX.Count + 2);
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
            Graphics g = base.CreateGraphics();
            g.Clear(Color.White);


            int x = 0;
            int y = 0;


            for (x = 1; x <= Dist.IntX.Count; x++)
            {
                g.DrawString(Dist.IntX[x - 1].ToString(), headerFont, Brushes.Indigo, x * lenght.Width, 0);
                g.DrawLine(pen, x * lenght.Width, 0, x * lenght.Width, base.Height);
            }
            g.DrawString("Marginal X", headerFont, Brushes.Indigo, x * lenght.Width, 0);
            g.DrawLine(pen, x * lenght.Width, 0, x * lenght.Width, base.Height);


            for (y = 1; y <= Dist.IntX.Count; y ++)
            {
                g.DrawString(Dist.IntY[y - 1].ToString(), headerFont, Brushes.Indigo, 0, y * lenght.Height);

                g.DrawLine(pen, 0, y * lenght.Height, base.Width, y * lenght.Height);
                // Joint Distribution
                
                for (x = 1; x <= Dist.IntX.Count; x++)
                {
                    g.DrawString(Dist.Matrix[y - 1][x - 1].ToString(), font, Brushes.Black, x * lenght.Width, y * lenght.Height);
                }

                // Marginal Distribution of X given Y 
                g.DrawString(Dist.GetMarginal(Variable.Y,y-1).ToString(), font, Brushes.Black, x * lenght.Width, y * lenght.Height);
            }
            g.DrawString("Marginal Y", headerFont , Brushes.Indigo, 0, y * lenght.Height);
            g.DrawLine(pen, 0, y * lenght.Height, base.Width, y * lenght.Height);

            for (x = 1; x <= Dist.IntX.Count; x++)
            {
                // Marginal Distribution of Y given X
                g.DrawString(Dist.GetMarginal(Variable.X, x-1).ToString(), font, Brushes.Black, x * lenght.Width, y * lenght.Height);
            }
            g.DrawString(Dist.Count.ToString(), font, Brushes.Black, x * lenght.Width, y * lenght.Height);
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
