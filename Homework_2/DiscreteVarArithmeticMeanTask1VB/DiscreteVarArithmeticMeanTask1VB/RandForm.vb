Public Class RandForm
    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        If Not running Then
            If Me.Limit.Text.Length < 1 Then
                Me.Limit.Text = "-1"
            End If

            Try
                Dim intervalStart As Integer = Integer.Parse(Me.intervalStart.Text)
                Dim intervalEnd As Integer = Integer.Parse(Me.intervalEnd.Text)
                Dim limit As Integer = Integer.Parse(Me.Limit.Text)
                Dim unitName As String = Me.unitNameBox.Text

                If unitName.Length < 1 Then
                    Throw New FormatException("Statistical Unit Name cant be empty")
                End If

                Dim attributeName As String = Me.attributeNameBox.Text

                If attributeName.Length < 1 Then
                    Throw New FormatException("Attribute Name cant be empty")
                End If

                Me.stream = New RandomDataStream(intervalStart, intervalEnd, unitName, attributeName, Me, limit)
                Me.updateInfo("Starting New Generation " & vbLf)
                Me.startButton.Text = "Stop"
                Me.running = True
                Me.cleanButton.Enabled = False
                Me.timer1.Start()
            Catch exception As FormatException
                MessageBox.Show(exception.Message)
            End Try
        Else
            Me.Stop()
        End If
    End Sub

    Public Sub [Stop]()
        Me.timer1.Stop()
        Me.updateInfo(String.Format(vbLf & "Average: {0,0:F3}", Me.stream.getAvg()))
        Me.updateInfo("-----------------------------------------" & vbLf)
        Me.startButton.Text = "Start"
        Me.running = False
        Me.cleanButton.Enabled = True
        Me.stream = Nothing 'Deletes the current stream
    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        Me.stream.next()
    End Sub
    Private Sub cleanButton_Click(sender As Object, e As EventArgs) Handles cleanButton.Click
        ' Clean all the text boxes
        Me.intervalStart.Text = ""
        Me.intervalEnd.Text = ""
        Me.realTimeInfoBox.Text = ""
        Me.unitNameBox.Text = ""
        Me.averageBox.Text = ""
        Me.attributeNameBox.Text = ""
    End Sub

    'Updaters 
    Public Sub updateAverage(average As Double)
        Me.averageBox.Text = String.Format("{0,0:F3}", average)
    End Sub

    Public Sub updateInfo(info As String)
        Me.realTimeInfoBox.Text += info & vbLf
    End Sub

    Public Sub ResetDistribution()
        Me.distributionTable.Text = String.Format("{0}" & vbTab & "{1}" & vbTab & "{2}" & vbTab & "{3}" & vbLf, "Value", "Count", "Frequency", "Percentage")
    End Sub

    Public Sub UpdateDistribution(distribution As String)
        Me.distributionTable.Text += distribution & vbLf
    End Sub

    Private Sub realTimeInfoBox_TextChanged(sender As Object, e As EventArgs)
        Me.realTimeInfoBox.SelectionStart = Me.realTimeInfoBox.Text.Length 'set current to caret
        Me.realTimeInfoBox.ScrollToCaret() ' scroll to caret
    End Sub

    Private stream As RandomDataStream
    Private running As Boolean

End Class
