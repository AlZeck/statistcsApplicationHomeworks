using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DiscreteVarArithmeticMeanTask1
{
    public partial class RandForm : Form
    {
        public RandForm()
        {
            InitializeComponent();
            // Temp 
            this.intervalStart.Text = "18";
            this.intervalEnd.Text = "31";
            this.unitNameBox.Text = "Student";
            this.attributeNameBox.Text = "Grades";
            // Temp
            this.running = false; // when the form starts the generator if off by default
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                if(this.Limit.Text.Length < 1)
                {
                    this.Limit.Text = "-1";
                }
                try
                {
                    int intervalStart = int.Parse(this.intervalStart.Text);
                    int intervalEnd = int.Parse(this.intervalEnd.Text);

                    int limit = int.Parse(this.Limit.Text);

                    String unitName = this.unitNameBox.Text;
                    if (unitName.Length < 1)
                    {
                        throw new FormatException("Statistical Unit Name cant be empty");
                    }

                    String attributeName = this.attributeNameBox.Text;
                    if (attributeName.Length < 1)
                    {
                        throw new FormatException("Attribute Name cant be empty");
                    }

                    this.stream = new RandomDataStream(intervalStart, intervalEnd, unitName, attributeName, this, limit);

                    this.updateInfo("Starting New Generation \n");

                    this.startButton.Text = "Stop";
                    this.running = true;
                    this.cleanButton.Enabled = false;
                    this.timer1.Start();

                }
                catch (FormatException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                this.stop();    
            }
        }

        public void stop()
        {
            this.timer1.Stop();
            this.updateInfo(String.Format("\nAverage: {0,0:F3}", this.stream.getAvg()));
            this.updateInfo("-----------------------------------------\n");
            this.startButton.Text = "Start";
            this.running = false;
            this.cleanButton.Enabled = true;
            this.stream = null; //Deletes the current stream
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.stream.next();
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            // Clean all the text boxes
            this.intervalStart.Text = "";
            this.intervalEnd.Text = "";
            this.realTimeInfoBox.Text = "";
            this.unitNameBox.Text = "";
            this.averageBox.Text = "";
            this.attributeNameBox.Text = "";           
        }


        //Updaters 
        public void updateAverage(double average)
        {
            this.averageBox.Text = String.Format("{0,0:F3}", average);
        }

        public void updateInfo(String info)
        {
            this.realTimeInfoBox.Text += info + "\n";
        }

        public void ResetDistribution()
        {
            this.distributionTable.Text = String.Format("{0}\t{1}\t{2}\t{3}\n", "Value", "Count","Frequency","Percentage"); 
        }

        public void UpdateDistribution(string distribution)
        {
            this.distributionTable.Text += distribution + "\n";
        }

        private void realTimeInfoBox_TextChanged(object sender, EventArgs e)
        {
            this.realTimeInfoBox.SelectionStart = this.realTimeInfoBox.Text.Length; //set current to caret
            this.realTimeInfoBox.ScrollToCaret(); // scroll to caret
        }

        private RandomDataStream stream;
        private Boolean running;
    }
}
