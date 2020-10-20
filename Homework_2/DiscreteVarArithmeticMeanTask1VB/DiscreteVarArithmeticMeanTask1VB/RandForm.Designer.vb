<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RandForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.startButton = New System.Windows.Forms.Button()
        Me.intervalStart = New System.Windows.Forms.TextBox()
        Me.intervalEnd = New System.Windows.Forms.TextBox()
        Me.startLabel = New System.Windows.Forms.Label()
        Me.endLabel = New System.Windows.Forms.Label()
        Me.cleanButton = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.unitNameBox = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.attributeNameBox = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.averageBox = New System.Windows.Forms.TextBox()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.label4 = New System.Windows.Forms.Label()
        Me.Limit = New System.Windows.Forms.TextBox()
        Me.realTimeInfoBox = New System.Windows.Forms.RichTextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.distributionTable = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(514, 13)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(94, 20)
        Me.startButton.TabIndex = 0
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'intervalStart
        '
        Me.intervalStart.Location = New System.Drawing.Point(88, 50)
        Me.intervalStart.Name = "intervalStart"
        Me.intervalStart.Size = New System.Drawing.Size(78, 20)
        Me.intervalStart.TabIndex = 1
        '
        'intervalEnd
        '
        Me.intervalEnd.Location = New System.Drawing.Point(255, 50)
        Me.intervalEnd.Name = "intervalEnd"
        Me.intervalEnd.Size = New System.Drawing.Size(78, 20)
        Me.intervalEnd.TabIndex = 2
        '
        'startLabel
        '
        Me.startLabel.AutoSize = True
        Me.startLabel.Location = New System.Drawing.Point(14, 54)
        Me.startLabel.Name = "startLabel"
        Me.startLabel.Size = New System.Drawing.Size(67, 13)
        Me.startLabel.TabIndex = 3
        Me.startLabel.Text = "Interval Start"
        '
        'endLabel
        '
        Me.endLabel.AutoSize = True
        Me.endLabel.Location = New System.Drawing.Point(183, 54)
        Me.endLabel.Name = "endLabel"
        Me.endLabel.Size = New System.Drawing.Size(64, 13)
        Me.endLabel.TabIndex = 4
        Me.endLabel.Text = "Interval End"
        '
        'cleanButton
        '
        Me.cleanButton.Location = New System.Drawing.Point(628, 13)
        Me.cleanButton.Name = "cleanButton"
        Me.cleanButton.Size = New System.Drawing.Size(106, 22)
        Me.cleanButton.TabIndex = 7
        Me.cleanButton.Text = "Clean"
        Me.cleanButton.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(14, 17)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(105, 13)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Statistical Unit Name"
        '
        'unitNameBox
        '
        Me.unitNameBox.Location = New System.Drawing.Point(125, 13)
        Me.unitNameBox.Name = "unitNameBox"
        Me.unitNameBox.Size = New System.Drawing.Size(132, 20)
        Me.unitNameBox.TabIndex = 8
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(263, 17)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(77, 13)
        Me.label2.TabIndex = 11
        Me.label2.Text = "Attribute Name"
        '
        'attributeNameBox
        '
        Me.attributeNameBox.Location = New System.Drawing.Point(346, 13)
        Me.attributeNameBox.Name = "attributeNameBox"
        Me.attributeNameBox.Size = New System.Drawing.Size(134, 20)
        Me.attributeNameBox.TabIndex = 10
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(561, 53)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(47, 13)
        Me.label3.TabIndex = 13
        Me.label3.Text = "Average"
        '
        'averageBox
        '
        Me.averageBox.Enabled = False
        Me.averageBox.Location = New System.Drawing.Point(625, 50)
        Me.averageBox.Name = "averageBox"
        Me.averageBox.Size = New System.Drawing.Size(109, 20)
        Me.averageBox.TabIndex = 12
        '
        'timer1
        '
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(345, 53)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(50, 13)
        Me.label4.TabIndex = 17
        Me.label4.Text = "Unit Limit"
        '
        'Limit
        '
        Me.Limit.Location = New System.Drawing.Point(401, 51)
        Me.Limit.Name = "Limit"
        Me.Limit.Size = New System.Drawing.Size(78, 20)
        Me.Limit.TabIndex = 15
        '
        'realTimeInfoBox
        '
        Me.realTimeInfoBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.realTimeInfoBox.Location = New System.Drawing.Point(12, 93)
        Me.realTimeInfoBox.Name = "realTimeInfoBox"
        Me.realTimeInfoBox.Size = New System.Drawing.Size(400, 273)
        Me.realTimeInfoBox.TabIndex = 5
        Me.realTimeInfoBox.Text = ""
        '
        'label5
        '
        Me.label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(433, 93)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(59, 13)
        Me.label5.TabIndex = 18
        Me.label5.Text = "Distribution"
        '
        'distributionTable
        '
        Me.distributionTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.distributionTable.HideSelection = False
        Me.distributionTable.Location = New System.Drawing.Point(431, 111)
        Me.distributionTable.Name = "distributionTable"
        Me.distributionTable.Size = New System.Drawing.Size(303, 255)
        Me.distributionTable.TabIndex = 19
        Me.distributionTable.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 379)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.Limit)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.averageBox)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.attributeNameBox)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.unitNameBox)
        Me.Controls.Add(Me.cleanButton)
        Me.Controls.Add(Me.distributionTable)
        Me.Controls.Add(Me.realTimeInfoBox)
        Me.Controls.Add(Me.endLabel)
        Me.Controls.Add(Me.startLabel)
        Me.Controls.Add(Me.intervalEnd)
        Me.Controls.Add(Me.intervalStart)
        Me.Controls.Add(Me.startButton)
        Me.Name = "Form1"
        Me.Text = "Random Discrete Variable Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents startButton As Button
    Friend WithEvents cleanButton As Button
    Private intervalStart As TextBox
    Private intervalEnd As TextBox
    Private startLabel As Label
    Private endLabel As Label
    Private label1 As Label
    Private unitNameBox As TextBox
    Private label2 As Label
    Private attributeNameBox As TextBox
    Private label3 As Label
    Private averageBox As TextBox
    Friend WithEvents timer1 As Timer
    Private label4 As Label
    Private Limit As TextBox
    Friend WithEvents realTimeInfoBox As RichTextBox
    Private label5 As Label
    Private distributionTable As RichTextBox

End Class
