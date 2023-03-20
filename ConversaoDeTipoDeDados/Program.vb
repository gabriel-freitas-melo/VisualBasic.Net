Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Casting exist com CInt, CType e objeto Convert.to")
        Dim numInt As Integer
        Dim numDouble As Double
        Dim numSingle As Single
        Dim word As String
        numDouble = 15.89123775459
        numInt = CInt(numDouble)
        Console.WriteLine(numInt)
        numInt = CType(numDouble, Integer)
        Console.WriteLine(numInt)
        numSingle = CType(numDouble, Single)
        Console.WriteLine(numSingle)
        word = Convert.toString(numDouble)
        Console.WriteLine(word)
    End Sub
End Module
