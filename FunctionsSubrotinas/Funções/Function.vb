Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Trabalhando com functions e subrotinas" & vbCrLf)
        Dim n1, n2, total As Double
        Console.WriteLine("Digite o primeiro valor:")
        n1 = Console.ReadLine()
        Console.WriteLine("Digite o segundo valor:")
        n2 = Console.ReadLine()
        total = Soma(n1, n2)
        Console.WriteLine($"Valor da soma �: {total}")
        total = Subtracao(n1, n2)
        Console.WriteLine($"Valor da subtra��o �: {total}")
        Produto(n1, n2)
    End Sub
    'Cria��o da function fora do main e ir� ser chamada durante a execu��o do main
    Function Soma(num1 As Double, num2 As Double) As Double
        Soma = num1 + num2
    End Function
    'Cria��o da subtra��o com return
    Function Subtracao(num1 As Double, num2 As Double) As Double
        Return (num1 - num2)
    End Function
    'Subrotinas n�o retornam valores mas podemos printar alguns resultados
    'Pode oassar vari�veis por refer�ncia
    Sub Produto(num1 As Double, num2 As Double)
        Console.WriteLine($"Valor do produto �: {num1 * num2}")
    End Sub
    'Usar byref seria semelhante ao this.valor em Java
End Module
