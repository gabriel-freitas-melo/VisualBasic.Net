Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("AND ALSO se a primeira condi��o for fal�a nem analisa a segunda")

        'COLETA DE DADOS

        Dim credito As Double
        Dim bloqueado As Boolean
        Console.WriteLine("Digite o valor do cr�dito do indiv�duo: ")
        credito = Console.ReadLine()
        Console.WriteLine("Digite true/false para o bloqueio do indiv�duo: ")
        bloqueado = Console.ReadLine()

        'OPERADORES L�GICOS

        If (credito > 10000 AndAlso bloqueado = False) Then
            Console.WriteLine("Inndiv�duo autorizado para a compra")
        Else
            Console.WriteLine("Indiv�duo n�o autorizado para a compra")
        End If

    End Sub
End Module
