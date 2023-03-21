Imports System


Module Program
    Sub Main(args As String())
        Dim salarioMensal, salarioAnual As Double
        Dim meses As Integer
        salarioMensal = 1500.0
        meses = 18
        salarioAnual = salarioMensal * meses
        'Cadeia de caracteres de formato composto
        Console.Writeline("Salario anual: {0:C}", salarioAnual)
        'Cadeia de caracteres de formato interpolado
        Console.WriteLine("Salário Anual: {salarioAnual}")
        Console.WriteLine("Fim do programa")


    End Sub
End Module
