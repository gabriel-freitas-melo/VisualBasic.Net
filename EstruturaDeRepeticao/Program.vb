Imports System

Module Program
    Sub Main(args As String())
        'Recebendo Dados
        Dim nome As String
        Dim nota As Single
        Console.WriteLine("Digite seu nome:")
        nome = Console.ReadLine()
        Console.WriteLine("Digite sua nota:")
        nota = Console.ReadLine()
        'Lógica if else
        If nota >= 7.0 Then
            Console.WriteLine($"Olá {nome}, você está aprovado")
        Else
            Console.WriteLine($"Olá {nome}, você está reprovado")
        End If
        'Lógica if elseif
        If nota >= 7.0 Then
            Console.WriteLine($"Olá {nome}, você está aprovado")
        ElseIf nota >= 5.0 Then
            Console.WriteLine($"Olá {nome}, você está de recuperação")
        Else
            Console.WriteLine($"Olá {nome}, você está reprovado")
        End If
        'Lógica Select Case
        Select Case nota
            Case 7 To 10
                Console.WriteLine($"Olá {nome}, você está aprovado")
            Case 5 To 7
                Console.WriteLine($"Olá {nome}, você está de recuperção")
            Case 0 To 5
                Console.WriteLine($"Olá {nome}, você está reprovado")
            Case Else
                Console.WriteLine($"Olá {nome}, você digitou um valor errado de nota")
        End Select
        Console.WriteLine("Fim do programa")

    End Sub
End Module
