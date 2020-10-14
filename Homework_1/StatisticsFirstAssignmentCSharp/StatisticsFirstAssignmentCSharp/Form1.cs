using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatisticsFirstAssCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text += "Hello World!";
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
        }

        private void ChangeColor_MouseEnter(object sender, EventArgs e)
        {
            this.richTextBox1.BackColor = System.Drawing.Color.Aqua;
        }

        private void ChangeColor_MouseLeave(object sender, EventArgs e)
        {
            this.richTextBox1.BackColor = System.Drawing.Color.White;
        }

        private void WriteButton_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void WriteButton_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                this.richTextBox1.Text += s[i] + "\n";
        }
    }
}
