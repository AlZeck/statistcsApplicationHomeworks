Imports System

Module Program

    Class MyRefInt
        Public i As Integer

        Public Sub New(i As Integer)
            Me.i = i
        End Sub
    End Class

    Structure MyValInt
        Public i As Integer

        Public Sub New(i As Integer)
            Me.i = i
        End Sub
    End Structure

    Sub Add10AndPrintRef(curr As MyRefInt)
        Console.WriteLine("Checking the value before the operation: " & curr.i)
        curr.i += 10
        Console.WriteLine("Checking the value after the operation: " & curr.i)
    End Sub

    Sub Add10AndPrintVal(curr As MyValInt)
        Console.WriteLine("Checking the value before the operation: " & curr.i)
        curr.i += 10
        Console.WriteLine("Checking the value after the operation: " & curr.i)
    End Sub

    Sub Main(args As String())
        Console.WriteLine("Creating 2 variables containing the same integer")
        Dim value As MyValInt = New MyValInt(10)
        Dim refer As MyRefInt = New MyRefInt(10)
        Console.WriteLine("------------------------------------------------------------")
        Console.WriteLine("Calling the function for the reference data type: " & refer.i)
        Add10AndPrintRef(refer)
        Console.WriteLine("Checking the value after the return of the function " &
                          "for the reference data type: " & refer.i)
        Console.WriteLine("------------------------------------------------------------")
        Console.WriteLine("Calling the function for the value data type: " & value.i)
        Add10AndPrintVal(value)
        Console.WriteLine("Checking the value after the return of the function " &
                          "for the value data type: " & value.i)
    End Sub
End Module
