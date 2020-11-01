namespace ChartsTask9App
{
    partial class ChartCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartCreator));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.addChart = new System.Windows.Forms.Button();
            this.attributeYCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.attributeXCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteChartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.deleteChartButton);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.addChart);
            this.splitContainer1.Panel1.Controls.Add(this.attributeYCombo);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.attributeXCombo);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.chartComboBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Size = new System.Drawing.Size(1510, 673);
            this.splitContainer1.SplitterDistance = 237;
            this.splitContainer1.TabIndex = 0;
            // 
            // addChart
            // 
            this.addChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addChart.Enabled = false;
            this.addChart.Location = new System.Drawing.Point(22, 173);
            this.addChart.Name = "addChart";
            this.addChart.Size = new System.Drawing.Size(193, 23);
            this.addChart.TabIndex = 6;
            this.addChart.Text = "Add Chart";
            this.addChart.UseVisualStyleBackColor = true;
            this.addChart.Click += new System.EventHandler(this.addChart_Click);
            // 
            // attributeYCombo
            // 
            this.attributeYCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attributeYCombo.Enabled = false;
            this.attributeYCombo.FormattingEnabled = true;
            this.attributeYCombo.Location = new System.Drawing.Point(22, 130);
            this.attributeYCombo.Name = "attributeYCombo";
            this.attributeYCombo.Size = new System.Drawing.Size(193, 21);
            this.attributeYCombo.TabIndex = 5;
            this.attributeYCombo.SelectedIndexChanged += new System.EventHandler(this.attributeYCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Attribute Y:";
            // 
            // attributeXCombo
            // 
            this.attributeXCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attributeXCombo.Enabled = false;
            this.attributeXCombo.FormattingEnabled = true;
            this.attributeXCombo.Location = new System.Drawing.Point(22, 81);
            this.attributeXCombo.Name = "attributeXCombo";
            this.attributeXCombo.Size = new System.Drawing.Size(193, 21);
            this.attributeXCombo.TabIndex = 3;
            this.attributeXCombo.SelectedIndexChanged += new System.EventHandler(this.attributeXCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Attribute X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a chart to add:";
            // 
            // chartComboBox
            // 
            this.chartComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartComboBox.FormattingEnabled = true;
            this.chartComboBox.Items.AddRange(new object[] {
            "Scatterplot",
            "Histogram",
            "Contingency Table"});
            this.chartComboBox.Location = new System.Drawing.Point(22, 32);
            this.chartComboBox.Name = "chartComboBox";
            this.chartComboBox.Size = new System.Drawing.Size(193, 21);
            this.chartComboBox.TabIndex = 0;
            this.chartComboBox.SelectedIndexChanged += new System.EventHandler(this.chartComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Selected Chart: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "none";
            this.label5.TextChanged += new System.EventHandler(this.label5_TextChanged);
            // 
            // deleteChartButton
            // 
            this.deleteChartButton.BackColor = System.Drawing.Color.DarkRed;
            this.deleteChartButton.Enabled = false;
            this.deleteChartButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteChartButton.Location = new System.Drawing.Point(22, 312);
            this.deleteChartButton.Name = "deleteChartButton";
            this.deleteChartButton.Size = new System.Drawing.Size(193, 31);
            this.deleteChartButton.TabIndex = 9;
            this.deleteChartButton.Text = "Delete Chart";
            this.deleteChartButton.UseVisualStyleBackColor = false;
            this.deleteChartButton.Click += new System.EventHandler(this.deleteChartButton_Click);
            // 
            // ChartCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1510, 673);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChartCreator";
            this.Text = "Eccel - Chart Creator";
            this.Load += new System.EventHandler(this.ChartCreator_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chartComboBox;
        private System.Windows.Forms.Button addChart;
        private System.Windows.Forms.ComboBox attributeYCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox attributeXCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteChartButton;
    }
}

