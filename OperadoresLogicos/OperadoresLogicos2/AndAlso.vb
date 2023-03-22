Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("AND ALSO se a primeira condição for falça nem analisa a segunda")

        'COLETA DE DADOS

        Dim credito As Double
        Dim bloqueado As Boolean
        Console.WriteLine("Digite o valor do crédito do indivíduo: ")
        credito = Console.ReadLine()
        Console.WriteLine("Digite true/false para o bloqueio do indivíduo: ")
        bloqueado = Console.ReadLine()

        'OPERADORES LÓGICOS

        If (credito > 10000 AndAlso bloqueado = False) Then
            Console.WriteLine("Inndivíduo autorizado para a compra")
        Else
            Console.WriteLine("Indivíduo não autorizado para a compra")
        End If

    End Sub
End Module
