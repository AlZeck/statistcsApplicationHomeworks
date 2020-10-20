using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContinuousVarArithmeticMeanTask2
{
    public partial class ContVarForm : Form
    {
        public const int START = 0;
        public const int END = 100;
        public const int STEP = 10;

        public ContVarForm()
        {
            InitializeComponent();
            Stream = new RandomStream(START, END);
            running = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if(running) 
            {
                startButton.Text = "Start";
                cleanButton.Enabled = true;
                running = false;
                timer1.Stop();
            }
            else
            {
                startButton.Text = "Stop";
                cleanButton.Enabled = false;
                running = true;
                if (Dist == null)
                    Dist = new Distribution(START, END, STEP);

                timer1.Start();
            }
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            Dist = null;
            infoBox.Text = "";
            distributionBox.Text = "";
            avgText.Text = "";
        }

        private void infoBox_TextChanged(object sender, EventArgs e)
        {
            this.infoBox.SelectionStart = this.infoBox.Text.Length; //set current to caret
            this.infoBox.ScrollToCaret(); // scroll to caret
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double entry = Stream.Next();
            Dist.Update(entry);
            infoBox.Text += String.Format("Student_{0} lives {1,0:F2}Km away from Sapienza's Campus\n", Dist.Count, entry);
            avgText.Text = String.Format("{0,0:F2}", Dist.Avg);
            distributionBox.Text = Dist.ToString();
        }

        private RandomStream Stream;
        private Distribution Dist;
        private bool running;
    }
}
