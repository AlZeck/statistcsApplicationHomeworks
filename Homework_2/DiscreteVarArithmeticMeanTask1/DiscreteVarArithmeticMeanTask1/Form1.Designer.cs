namespace DiscreteVarArithmeticMeanTask1
{
    partial class RandForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.intervalStart = new System.Windows.Forms.TextBox();
            this.intervalEnd = new System.Windows.Forms.TextBox();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.cleanButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.unitNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.attributeNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.averageBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.Limit = new System.Windows.Forms.TextBox();
            this.realTimeInfoBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.distributionTable = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(514, 13);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 20);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // intervalStart
            // 
            this.intervalStart.Location = new System.Drawing.Point(88, 50);
            this.intervalStart.Name = "intervalStart";
            this.intervalStart.Size = new System.Drawing.Size(78, 20);
            this.intervalStart.TabIndex = 1;
            // 
            // intervalEnd
            // 
            this.intervalEnd.Location = new System.Drawing.Point(255, 50);
            this.intervalEnd.Name = "intervalEnd";
            this.intervalEnd.Size = new System.Drawing.Size(78, 20);
            this.intervalEnd.TabIndex = 2;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(14, 54);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(67, 13);
            this.startLabel.TabIndex = 3;
            this.startLabel.Text = "Interval Start";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(183, 54);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(64, 13);
            this.endLabel.TabIndex = 4;
            this.endLabel.Text = "Interval End";
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(628, 13);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(106, 22);
            this.cleanButton.TabIndex = 7;
            this.cleanButton.Text = "Clean";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Statistical Unit Name";
            // 
            // unitNameBox
            // 
            this.unitNameBox.Location = new System.Drawing.Point(125, 13);
            this.unitNameBox.Name = "unitNameBox";
            this.unitNameBox.Size = new System.Drawing.Size(132, 20);
            this.unitNameBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Attribute Name";
            // 
            // attributeNameBox
            // 
            this.attributeNameBox.Location = new System.Drawing.Point(346, 13);
            this.attributeNameBox.Name = "attributeNameBox";
            this.attributeNameBox.Size = new System.Drawing.Size(134, 20);
            this.attributeNameBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Average";
            // 
            // averageBox
            // 
            this.averageBox.Enabled = false;
            this.averageBox.Location = new System.Drawing.Point(625, 50);
            this.averageBox.Name = "averageBox";
            this.averageBox.Size = new System.Drawing.Size(109, 20);
            this.averageBox.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Unit Limit";
            // 
            // Limit
            // 
            this.Limit.Location = new System.Drawing.Point(401, 51);
            this.Limit.Name = "Limit";
            this.Limit.Size = new System.Drawing.Size(78, 20);
            this.Limit.TabIndex = 15;
            // 
            // realTimeInfoBox
            // 
            this.realTimeInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.realTimeInfoBox.Location = new System.Drawing.Point(12, 93);
            this.realTimeInfoBox.Name = "realTimeInfoBox";
            this.realTimeInfoBox.Size = new System.Drawing.Size(400, 273);
            this.realTimeInfoBox.TabIndex = 5;
            this.realTimeInfoBox.Text = "";
            this.realTimeInfoBox.TextChanged += new System.EventHandler(this.realTimeInfoBox_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Distribution";
            // 
            // distributionTable
            // 
            this.distributionTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.distributionTable.HideSelection = false;
            this.distributionTable.Location = new System.Drawing.Point(431, 111);
            this.distributionTable.Name = "distributionTable";
            this.distributionTable.Size = new System.Drawing.Size(303, 255);
            this.distributionTable.TabIndex = 19;
            this.distributionTable.Text = "";
            // 
            // RandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 379);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Limit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.averageBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.attributeNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unitNameBox);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.distributionTable);
            this.Controls.Add(this.realTimeInfoBox);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.intervalEnd);
            this.Controls.Add(this.intervalStart);
            this.Controls.Add(this.startButton);
            this.Name = "RandForm";
            this.Text = "Random Discrete Variable Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox intervalStart;
        private System.Windows.Forms.TextBox intervalEnd;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox unitNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox attributeNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox averageBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Limit;
        private System.Windows.Forms.RichTextBox realTimeInfoBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox distributionTable;
    }
}

