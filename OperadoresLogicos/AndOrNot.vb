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
        If (media >= 6 And frequencia >= 75) Then
            Console.WriteLine("Aprovado")
        Else
            Console.WriteLine("Reprovado")
        End If
        'or
        If (media >= 6 And frequencia >= 75) Then
            Console.WriteLine("Aprovado")
        ElseIf (media >= 5 Or frequencia >= 75) Then
            Console.WriteLine("Recupera��o")
        Else
            Console.WriteLine("Reprovado")

        End If
        'not

        If media < 6 Then
            Console.WriteLine("Voc� precisa de refor�o")
            Dim result As Boolean = Not reforco
            Console.WriteLine(result)
        End If

        Console.WriteLine("Fim do programa")

    End Sub
End Module
