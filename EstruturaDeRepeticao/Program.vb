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
        'L�gica if else
        If nota >= 7.0 Then
            Console.WriteLine($"Ol� {nome}, voc� est� aprovado")
        Else
            Console.WriteLine($"Ol� {nome}, voc� est� reprovado")
        End If
        'L�gica if elseif
        If nota >= 7.0 Then
            Console.WriteLine($"Ol� {nome}, voc� est� aprovado")
        ElseIf nota >= 5.0 Then
            Console.WriteLine($"Ol� {nome}, voc� est� de recupera��o")
        Else
            Console.WriteLine($"Ol� {nome}, voc� est� reprovado")
        End If
        'L�gica Select Case
        Select Case nota
            Case 7 To 10
                Console.WriteLine($"Ol� {nome}, voc� est� aprovado")
            Case 5 To 7
                Console.WriteLine($"Ol� {nome}, voc� est� de recuper��o")
            Case 0 To 5
                Console.WriteLine($"Ol� {nome}, voc� est� reprovado")
            Case Else
                Console.WriteLine($"Ol� {nome}, voc� digitou um valor errado de nota")
        End Select
        Console.WriteLine("Fim do programa")

    End Sub
End Module
