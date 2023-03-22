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
        If (media >= 6 And frequencia >= 75) Then
            Console.WriteLine("Aprovado")
        Else
            Console.WriteLine("Reprovado")
        End If
        'or
        If (media >= 6 And frequencia >= 75) Then
            Console.WriteLine("Aprovado")
        ElseIf (media >= 5 Or frequencia >= 75) Then
            Console.WriteLine("Recuperação")
        Else
            Console.WriteLine("Reprovado")

        End If
        'not

        If media < 6 Then
            Console.WriteLine("Você precisa de reforço")
            Dim result As Boolean = Not reforco
            Console.WriteLine(result)
        End If

        Console.WriteLine("Fim do programa")

    End Sub
End Module
