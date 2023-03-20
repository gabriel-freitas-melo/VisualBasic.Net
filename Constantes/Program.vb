Imports System



Module Program
    Sub Main(args As String())
        Console.WriteLine("Trabalhando com constantes")
        Const salarioMensal As Double = 2500.0
        Const meses As UInteger = 12
        Dim salarioAnual As Double
        salarioAnual = salarioMensal * meses
        Console.Writeline($"Salario anual = {salarioAnual:C}")
    End Sub
End Module
