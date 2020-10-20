
Class RandomDataStream
    Public Sub New(start As Integer, [end] As Integer, unitName As String, attributeName As String, form As RandForm, limit As Integer)
        Me.start = start
        Me.end = [end]
        Me.unitName = unitName
        Me.attributeName = attributeName
        Me.form = form
        average = 0
        unitCounter = 0
        random = New Random()
        Me.limit = limit
        distribution = New Dictionary(Of Integer, container)()

        If limit < 0 AndAlso limit <> -1 Then
            Throw New FormatException("Check limit must be a positive integer or -1 for infinite")
        End If

        Me.form.ResetDistribution()

        For x As Integer = start To [end] - 1
            distribution.Add(x, New container())
            Me.form.UpdateDistribution(String.Format("{0}" & vbTab & "{1}", x, distribution(x).ToString()))
        Next
    End Sub

    Private Function generateRandom() As Integer
        Return random.Next(start, [end])
    End Function

    Public Sub [next]()
        If limit = -1 OrElse unitCounter <= limit Then
            Dim current As Integer = generateRandom()
            unitCounter += 1
            average = average + (current - average) / unitCounter
            updateDistribution(current)
            updateForm(current)
        Else
            form.[Stop]()
        End If
    End Sub

    Public Sub updateForm(last As Integer)
        form.updateInfo(unitName & unitCounter & ": " & last)
        form.updateAverage(average)
    End Sub

    Public Sub updateDistribution(last As Integer)
        form.ResetDistribution()
        distribution(last).count += 1

        For x As Integer = start To [end] - 1
            distribution(x).updateFrequency(unitCounter)
            form.UpdateDistribution(String.Format("{0}" & vbTab & "{1}", x, distribution(x).ToString()))
        Next

        form.UpdateDistribution(vbLf & "Total " & unitName & ": " & unitCounter)
    End Sub

    Public Function getAvg() As Double
        Return average
    End Function

    Private random As Random
    Private start As Integer
    Private [end] As Integer
    Private attributeName As String
    Private unitName As String
    Private form As RandForm
    Private average As Double
    Private unitCounter As Integer
    Private distribution As Dictionary(Of Integer, container)
    Private [step] As Integer
    Private limit As Integer
End Class

Class container
    Public count As Integer
    Public frequency As Double
    Public percentage As Double

    Public Sub New()
        count = 0
        frequency = 0
        percentage = 0
    End Sub

    Public Sub updateFrequency(ByVal n As Integer)
        frequency = count / n
        percentage = count / n * 100.0
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("{0}" & vbTab & "{1,0:F3}" & vbTab & vbTab & "{2,0:F2}%", count, frequency, percentage)
    End Function
End Class