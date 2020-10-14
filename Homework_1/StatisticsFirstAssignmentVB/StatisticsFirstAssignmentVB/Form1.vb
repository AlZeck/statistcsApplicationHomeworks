Imports System.IO

Public Class Form1

    Private Sub WriteButton_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.RichTextBox1.Text = "Hello World "
    End Sub

    Private Sub CleanButton_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.RichTextBox1.Text = ""
    End Sub

    Private Sub ChangeColor_MouseEnter(sender As Object, e As EventArgs) Handles RichTextBox1.MouseEnter
        Me.RichTextBox1.BackColor = System.Drawing.Color.Aqua
    End Sub

    Private Sub ChangeColor_MouseLeave(sender As Object, e As EventArgs) Handles RichTextBox1.MouseLeave
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
    End Sub

    Private Sub WriteButton_DragEnter(sender As Object, e As DragEventArgs) Handles Button1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub WriteButton_DragDrop(sender As Object, e As DragEventArgs) Handles Button1.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop, False)
        For Each path In files
            Me.RichTextBox1.Text += path + vbCrLf
        Next
    End Sub

End Class
