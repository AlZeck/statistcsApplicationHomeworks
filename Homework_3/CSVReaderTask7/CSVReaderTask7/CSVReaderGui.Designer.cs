namespace CSVReaderTask7
{
    partial class CSVReaderGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSVReaderGui));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.selectDivisor = new System.Windows.Forms.GroupBox();
            this.radioSemicolon = new System.Windows.Forms.RadioButton();
            this.radioComma = new System.Windows.Forms.RadioButton();
            this.containsHeaderCheck = new System.Windows.Forms.CheckBox();
            this.FilePath = new System.Windows.Forms.Label();
            this.ReadButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateAttribute = new System.Windows.Forms.Button();
            this.AttributeTypeBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AttributeNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.selectDivisor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // selectDivisor
            // 
            this.selectDivisor.Controls.Add(this.radioSemicolon);
            this.selectDivisor.Controls.Add(this.radioComma);
            this.selectDivisor.Location = new System.Drawing.Point(15, 24);
            this.selectDivisor.Name = "selectDivisor";
            this.selectDivisor.Size = new System.Drawing.Size(139, 73);
            this.selectDivisor.TabIndex = 1;
            this.selectDivisor.TabStop = false;
            this.selectDivisor.Text = "Field Delimiter";
            // 
            // radioSemicolon
            // 
            this.radioSemicolon.AutoSize = true;
            this.radioSemicolon.Location = new System.Drawing.Point(7, 44);
            this.radioSemicolon.Name = "radioSemicolon";
            this.radioSemicolon.Size = new System.Drawing.Size(92, 17);
            this.radioSemicolon.TabIndex = 1;
            this.radioSemicolon.Text = "Semicolon ( ; )";
            this.radioSemicolon.UseVisualStyleBackColor = true;
            this.radioSemicolon.CheckedChanged += new System.EventHandler(this.FieldDelimeter_CheckedChanged);
            // 
            // radioComma
            // 
            this.radioComma.AutoSize = true;
            this.radioComma.Checked = true;
            this.radioComma.Location = new System.Drawing.Point(7, 20);
            this.radioComma.Name = "radioComma";
            this.radioComma.Size = new System.Drawing.Size(78, 17);
            this.radioComma.TabIndex = 0;
            this.radioComma.TabStop = true;
            this.radioComma.Text = "Comma ( , )";
            this.radioComma.UseVisualStyleBackColor = true;
            this.radioComma.CheckedChanged += new System.EventHandler(this.FieldDelimeter_CheckedChanged);
            // 
            // containsHeaderCheck
            // 
            this.containsHeaderCheck.AutoSize = true;
            this.containsHeaderCheck.Location = new System.Drawing.Point(170, 32);
            this.containsHeaderCheck.Name = "containsHeaderCheck";
            this.containsHeaderCheck.Size = new System.Drawing.Size(103, 17);
            this.containsHeaderCheck.TabIndex = 2;
            this.containsHeaderCheck.Text = "Contains header";
            this.containsHeaderCheck.UseVisualStyleBackColor = true;
            // 
            // FilePath
            // 
            this.FilePath.AutoSize = true;
            this.FilePath.Location = new System.Drawing.Point(19, 7);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(29, 13);
            this.FilePath.TabIndex = 3;
            this.FilePath.Text = "Path";
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(170, 66);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(103, 29);
            this.ReadButton.TabIndex = 4;
            this.ReadButton.Text = "Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectDivisor);
            this.panel1.Controls.Add(this.containsHeaderCheck);
            this.panel1.Controls.Add(this.ReadButton);
            this.panel1.Controls.Add(this.FilePath);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.MaximumSize = new System.Drawing.Size(288, 114);
            this.panel1.MinimumSize = new System.Drawing.Size(288, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 114);
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 372);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attributes";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 16);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(270, 353);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(295, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 416);
            this.dataGridView1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.updateAttribute);
            this.groupBox2.Controls.Add(this.AttributeTypeBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.AttributeNameBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(295, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 69);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Atribute ";
            // 
            // updateAttribute
            // 
            this.updateAttribute.Location = new System.Drawing.Point(437, 30);
            this.updateAttribute.Name = "updateAttribute";
            this.updateAttribute.Size = new System.Drawing.Size(192, 24);
            this.updateAttribute.TabIndex = 4;
            this.updateAttribute.Text = "Save";
            this.updateAttribute.UseVisualStyleBackColor = true;
            this.updateAttribute.Click += new System.EventHandler(this.updateAttribute_Click);
            // 
            // AttributeTypeBox
            // 
            this.AttributeTypeBox.FormattingEnabled = true;
            this.AttributeTypeBox.Items.AddRange(new object[] {
            "Int32",
            "Double",
            "DateTime",
            "Boolean",
            "String"});
            this.AttributeTypeBox.Location = new System.Drawing.Point(253, 30);
            this.AttributeTypeBox.Name = "AttributeTypeBox";
            this.AttributeTypeBox.Size = new System.Drawing.Size(154, 21);
            this.AttributeTypeBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // AttributeNameBox
            // 
            this.AttributeNameBox.Location = new System.Drawing.Point(55, 30);
            this.AttributeNameBox.Name = "AttributeNameBox";
            this.AttributeNameBox.Size = new System.Drawing.Size(135, 20);
            this.AttributeNameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // CSVReaderGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 531);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CSVReaderGui";
            this.Text = "Eccel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.selectDivisor.ResumeLayout(false);
            this.selectDivisor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox selectDivisor;
        private System.Windows.Forms.RadioButton radioSemicolon;
        private System.Windows.Forms.RadioButton radioComma;
        private System.Windows.Forms.Label FilePath;
        private System.Windows.Forms.CheckBox containsHeaderCheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox AttributeTypeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AttributeNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button updateAttribute;
    }
}

