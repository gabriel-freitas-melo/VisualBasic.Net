Imports System



Module Program
    Sub Main(args As String())
        Console.WriteLine("Trabalhando com constantes")
        Const salarioMensal As Double = 2500.0
        Const meses As UInteger = 12
        Dim salarioAnual As Double
        salarioAnual = salarioMensal * meses
        Console.WriteLine($"Salario anual = {salarioAnual:C}")
        Console.WriteLine("Fim do programa")


    End Sub
End Module
