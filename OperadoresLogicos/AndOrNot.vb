Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Trabalhando com operadores L�gicos")
        Dim media As Double
        Dim frequencia As Double
        Console.WriteLine("Digite a m�dia:")
        media = Console.ReadLine()
        Console.WriteLine("Digite a frequencia:")
        frequencia = Console.ReadLine()
        Dim reforco As Boolean = False

        'and
        If media >= 6.0 And frequencia >= 0.75 Then
            Console.WriteLine("Aprovado")
        Else
            Console.WriteLine("Reprovado")
        End If
        'or
        If media >= 6.0 And frequencia >= 0.75 Then
            Console.WriteLine("Aprovado")
        ElseIf media >= 5.0 Or frequencia < 0.75 Then
            Console.WriteLine("Recupera��o")
        Else
            Console.WriteLine("Reprovado")

        End If
        'not
        If media <= 6.0 Then
            Console.WriteLine("Precisa de refor�o?")
            Console.WriteLine(Not reforco)
        End If

    End Sub
End Module
