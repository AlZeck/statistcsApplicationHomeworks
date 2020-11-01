using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartsTask9App
{
    public partial class ChartCreator : Form
    {
        public const int START = 0;
        public const int END = 100;
        public const int STEP = 10;

        public ChartCreator()
        {
            InitializeComponent();
            lisChart = new List<IChart>();
        }

        private List<IChart> lisChart;

        private void button1_Click(object sender, EventArgs e)
        {
            RandomStream rs = new RandomStream(START, END);
            // DEFINE DISTRIBUTIONS
            Distribution dx = new Distribution(START, END, STEP);
            Distribution dy = new Distribution(START, END, STEP);
            BivariateDistribution bd = new BivariateDistribution(START, END, STEP, START, END, STEP);

            List<PointF> dataStream = new List<PointF>();

            //CALCULATE DISTRIBUTIONS
            for (int i = 0; i < 100; i++)
            {
                double py = rs.Next();
                double px = rs.Next();
                dx.Update(px);
                dy.Update(py);
                bd.Update(px, py);
                PointF p = new PointF((float)px, (float)py);
                dataStream.Add(p);
            }

            ScatterPlot sc = new ScatterPlot(dataStream, START, END - START, START, END - START, (float)dx.Avg, (float)dy.Avg);
            Histogram hx = new Histogram(dx, Orientation.Horizontal);
            Histogram hy = new Histogram(dy, Orientation.Horizontal);
            ContingencyTable ct = new ContingencyTable(bd);

            List<IChart> toAdd = new List<IChart>() { sc, hx, hy, ct };
            foreach (IChart ic in toAdd)
            {
                this.Controls.Add((Panel)ic);
            }

            lisChart.AddRange(toAdd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (IChart ic in lisChart)
            {
                ic.UpdateContent();
            }
        }


        public List<HeaderContainer> Header;
        public List<List<Object>> Elements;

        private void chartComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (attributeXCombo.Items.Count < 1 || attributeYCombo.Items.Count < 1) {
                attributeXCombo.Items.Clear();
                attributeYCombo.Items.Clear();
                var available = Header.Select(x => x.HeaderName).ToArray();

                attributeXCombo.Items.AddRange(available);
                attributeYCombo.Items.AddRange(available);

                attributeXCombo.Text = "";
                attributeYCombo.Text = "";
            }
            switch (chartComboBox.SelectedItem)
            {
                case "Scatterplot":
                    attributeXCombo.Enabled = true;
                    attributeYCombo.Enabled = true;
                    break;
                case "Histogram":
                    attributeXCombo.Enabled = true;
                    attributeYCombo.Enabled = false;
                    break;
                case "Contingency Table":
                    attributeXCombo.Enabled = true;
                    attributeYCombo.Enabled = true;
                    break;
                default:
                    attributeXCombo.Enabled = false;
                    attributeYCombo.Enabled = false;
                    break;
            }
        }




        private void addChart_Click(object sender, EventArgs e)
        {
            int x = attributeXCombo.SelectedIndex;
            int y = attributeYCombo.SelectedIndex;

            switch (chartComboBox.SelectedItem)
            {
                case "Scatterplot":
                    AddScatterplot(x, y);
                    break;
                case "Histogram":
                    AddHistogram(x);
                    break;
                case "Contingency Table":
                    AddContingencyTable(x, y);
                    break;
                default:
                    break;
            }
        }

        private void AddContingencyTable(int x, int y)
        {
            var lisx = Elements.Select(row => row[x]).ToList();
            var lisy = Elements.Select(row => row[y]).ToList();

            int startx = Convert.ToInt32(lisx.Min());
            int endx = Convert.ToInt32(lisx.Max()) + 1;
            int stepx = (int)Math.Ceiling((double)(endx - startx) / 10);

            int starty = Convert.ToInt32(lisy.Min());
            int endy = Convert.ToInt32(lisy.Max())+1;
            int stepy = (int)Math.Ceiling((double)(endy - starty) / 10);

            BivariateDistribution bd = new BivariateDistribution(startx, endx, stepx, starty, endy, stepy);

            //CALCULATE DISTRIBUTIONS
            for (int i = 0; i < Elements.Count; i++)
            {
                double px = Convert.ToDouble(lisx[i]);
                double py = Convert.ToDouble(lisy[i]);
                bd.Update(px, py);
            }

            ContingencyTable ct = new ContingencyTable(bd);
            ct.Name = "ContingencyTable" + Header[x] + Header[y];
            ct.Click += new EventHandler(selectChart_Click);

            List<IChart> toAdd = new List<IChart>() { ct };
            splitContainer1.Panel2.Controls.Add(ct);
            lisChart.Add(ct);
        }

        private void AddHistogram(int x)
        {
            var lisx = Elements.Select(row => row[x]).ToList();

            int startx = Convert.ToInt32(lisx.Min());
            int endx = Convert.ToInt32(lisx.Max()) + 1;
            int stepx = (int)Math.Ceiling((double)(endx - startx) / 10);

            Distribution dx = new Distribution(startx, endx, stepx);
            List<PointF> dataStream = new List<PointF>();
            //CALCULATE DISTRIBUTIONS
            for (int i = 0; i < Elements.Count; i++)
            {
                double px = Convert.ToDouble(lisx[i]);
                dx.Update(px);
            }

            Histogram hx = new Histogram(dx, Orientation.Horizontal);
            hx.Name = "Histogram" + Header[x];
            hx.Click += new EventHandler(selectChart_Click);

            List<IChart> toAdd = new List<IChart>() { hx };
            splitContainer1.Panel2.Controls.Add(hx);
            lisChart.Add(hx);
        }

        private void AddScatterplot(int x, int y)
        {
            var lisx = Elements.Select(row => row[x]).ToList();
            var lisy = Elements.Select(row => row[y]).ToList();

            int startx = Convert.ToInt32(lisx.Min());
            int endx = Convert.ToInt32(lisx.Max()) + 1;
            int stepx = (int)Math.Ceiling((double)(endx - startx) / 10);

            int starty = Convert.ToInt32(lisy.Min());
            int endy = Convert.ToInt32(lisy.Max()) + 1;
            int stepy = (int)Math.Ceiling((double)(endy - starty) / 10);

            Distribution dx = new Distribution(startx, endx, stepx);
            Distribution dy = new Distribution(starty, endy, stepy);
            List<PointF> dataStream = new List<PointF>();
            //CALCULATE DISTRIBUTIONS
            for (int i = 0; i < Elements.Count; i++)
            {
                double px = Convert.ToDouble(lisx[i]);
                double py = Convert.ToDouble(lisy[i]);
                dx.Update(px);
                dy.Update(py);
                PointF p = new PointF((float)px, (float)py);
                dataStream.Add(p);
            }

            ScatterPlot sc = new ScatterPlot(dataStream, startx, endx - startx, starty, endy - starty, (float)dx.Avg, (float)dy.Avg);
            sc.Name = "ScatterPlot" + Header[x] + Header[y];
            sc.Click += new EventHandler(selectChart_Click);

            List<IChart> toAdd = new List<IChart>() { sc };
            splitContainer1.Panel2.Controls.Add(sc);
            lisChart.Add(sc);
        }

        IChart selectedChart;

        private void selectChart_Click(object sender, EventArgs e)
        {
            if (sender is IChart && sender is Panel)
            {
                selectedChart = (IChart)sender;
                label5.Text = ((Panel)sender).Name;
            }

        }


        private void label5_TextChanged(object sender, EventArgs e)
        {
            deleteChartButton.Enabled = (label5.Text.Length > 1) ? true : false;
        }

        private void deleteChartButton_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Remove((Panel)selectedChart);
            lisChart.Remove(selectedChart);
            label5.Text = "";
        }

        private void ChartCreator_Load(object sender, EventArgs e)
        {
            label5.Text = "";
        }

        private void attributeXCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( attributeXCombo.SelectedIndex != -1 && (attributeYCombo.SelectedIndex != -1 || chartComboBox.SelectedItem.Equals("Histogram")))
            {
                addChart.Enabled = true;
            }
            else
            {
                addChart.Enabled = false;
            }
        }

        private void attributeYCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (attributeXCombo.SelectedIndex != -1 && attributeYCombo.SelectedIndex != -1 )
            {
                addChart.Enabled = true;
            }
            else
            {
                addChart.Enabled = false;
            }
        }
    }
}
