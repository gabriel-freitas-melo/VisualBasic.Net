Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Trabalhando com operadores Lógicos")
        Dim media As Double
        Dim frequencia As Double
        Console.WriteLine("Digite a média:")
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
            Console.WriteLine("Recuperação")
        Else
            Console.WriteLine("Reprovado")

        End If
        'not
        If media <= 6.0 Then
            Console.WriteLine("Precisa de reforço?")
            Console.WriteLine(Not reforco)
        End If

    End Sub
End Module
