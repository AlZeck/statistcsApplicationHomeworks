using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic.FileIO;



namespace CSVReaderTask7
{
    public partial class CSVReaderGui : Form
    {
        public CSVReaderGui()
        {
            InitializeComponent();
            FilePath.Text = "";
            Delimiter = ",";
        }
        public string Delimiter { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select A File";
            openDialog.Filter = "Text Files (*.csv)|*.csv" + "|" +
                                "All Files (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath.Text = openDialog.FileName;
            }
        }

        private void FieldDelimeter_CheckedChanged(object sender, EventArgs e)
        {
            if (radioComma.Checked)
            {
                Delimiter = ",";
            }
            else if (radioSemicolon.Checked)
            {
                Delimiter = ";";
            }
        }

        public void updateTreeView()
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();
            List<HeaderContainer> lis = CSVP.Header;
            for (int i = 0; i < lis.Count; i++)
            {
                treeView1.Nodes.Add("Column " + (i + 1) + ": " + lis[i].ToString());
                treeView1.Nodes[i].Nodes.Add("Name: " + lis[i].HeaderName);
                treeView1.Nodes[i].Nodes.Add("Type: " + lis[i].Type.Name);
            }
            treeView1.EndUpdate();
        }

        public void writeLine(string line)
        {

        }

        private void readButton_Click(object sender, EventArgs e)
        {
            CSVP = new CSVParser(FilePath.Text, this, containsHeaderCheck.Checked);
            updateTreeView();
            updateGridView();
        }


        private CSVParser CSVP;


        private int selectedTreeIndex;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tn = treeView1.SelectedNode;
            selectedTreeIndex = int.Parse(tn.FullPath.Split(':')[0].Substring(7)) - 1;
            updateAtributteUpdater();
        }

        private void updateAtributteUpdater()
        {
            AttributeNameBox.Text = CSVP.Header[selectedTreeIndex].HeaderName;
            AttributeTypeBox.Text = CSVP.Header[selectedTreeIndex].Type.Name;
        }

        private void updateAttribute_Click(object sender, EventArgs e)
        {
            Type beforeUpdate = CSVP.Header[selectedTreeIndex].Type;
            if (AttributeNameBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("Attribute name cant be empty");
                return;
            }

            CSVP.Header[selectedTreeIndex].HeaderName = AttributeNameBox.Text.Trim();
            switch (AttributeTypeBox.Text)
            {
                case "Int32":
                    CSVP.Header[selectedTreeIndex].Type = typeof(int);
                    break;
                case "Double":
                    CSVP.Header[selectedTreeIndex].Type = typeof(double);
                    break;
                case "DateTime":
                    CSVP.Header[selectedTreeIndex].Type = typeof(DateTime);
                    break;
                case "Boolean":
                    CSVP.Header[selectedTreeIndex].Type = typeof(bool);
                    break;
                case "String":
                    CSVP.Header[selectedTreeIndex].Type = typeof(string);
                    break;
                default:
                    break;
            }
            try
            {
                CSVP.ParseElements();
            }
            catch (Exception exc)
            {
                CSVP.Header[selectedTreeIndex].Type = beforeUpdate;
            }
            updateTreeView();
            updateGridView();
        }

        public void updateGridView()
        {
            dataGridView1.Columns.Clear();
            List<HeaderContainer> headers = CSVP.Header;
            for (int i = 0; i < headers.Count; i++)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = headers[i].HeaderName;
                dataGridView1.Columns.Add(col);
            }

            foreach (List<object> r in CSVP.Elements)
            {
                dataGridView1.Rows.Add(r.ToArray());
            }

        }
    }
}

