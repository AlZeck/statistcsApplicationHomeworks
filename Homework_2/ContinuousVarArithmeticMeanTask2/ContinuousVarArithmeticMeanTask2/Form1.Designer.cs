namespace ContinuousVarArithmeticMeanTask2
{
    partial class ContVarForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.distributionBox = new System.Windows.Forms.RichTextBox();
            this.avgText = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.infoBox);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.distributionBox);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 474;
            this.splitContainer1.TabIndex = 0;
            // 
            // infoBox
            // 
            this.infoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoBox.Location = new System.Drawing.Point(0, 37);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(474, 413);
            this.infoBox.TabIndex = 3;
            this.infoBox.Text = "";
            this.infoBox.TextChanged += new System.EventHandler(this.infoBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.cleanButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 31);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.avgText);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 31);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Average Distance";
            // 
            // distributionBox
            // 
            this.distributionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.distributionBox.Location = new System.Drawing.Point(0, 37);
            this.distributionBox.Name = "distributionBox";
            this.distributionBox.Size = new System.Drawing.Size(322, 413);
            this.distributionBox.TabIndex = 0;
            this.distributionBox.Text = "";
            // 
            // avgText
            // 
            this.avgText.Location = new System.Drawing.Point(143, 6);
            this.avgText.Name = "avgText";
            this.avgText.Size = new System.Drawing.Size(140, 20);
            this.avgText.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Location = new System.Drawing.Point(0, 0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(224, 31);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cleanButton.Location = new System.Drawing.Point(230, 0);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(244, 31);
            this.cleanButton.TabIndex = 1;
            this.cleanButton.Text = "Clean";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ContVarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ContVarForm";
            this.Text = "Continuos Variable Generator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox infoBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox distributionBox;
        private System.Windows.Forms.TextBox avgText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Timer timer1;
    }
}

