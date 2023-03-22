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
        Console.WriteLine($"Valor da soma é: {total}")
        total = Subtracao(n1, n2)
        Console.WriteLine($"Valor da subtração é: {total}")
        Produto(n1, n2)
    End Sub
    'Criação da function fora do main e irá ser chamada durante a execução do main
    Function Soma(num1 As Double, num2 As Double) As Double
        Soma = num1 + num2
    End Function
    'Criação da subtração com return
    Function Subtracao(num1 As Double, num2 As Double) As Double
        Return (num1 - num2)
    End Function
    'Subrotinas não retornam valores mas podemos printar alguns resultados
    'Pode oassar variáveis por referência
    Sub Produto(num1 As Double, num2 As Double)
        Console.WriteLine($"Valor do produto é: {num1 * num2}")
    End Sub
    'Usar byref seria semelhante ao this.valor em Java
End Module
