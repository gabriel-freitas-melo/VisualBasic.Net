Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Estrutura WHILE" & vbCrLf)

        'Estrutura While
        'While condicao
        '   comando
        '   Continue While
        '   Exit While
        'End While

        Dim i As Integer
        i = 0

        Console.WriteLine("Primeiro teste" & vbCrLf)
        While (i <= 10)
            Console.WriteLine($"Contador = {i}" & vbCrLf)
            i += 1
        End While

        i = 0
        Console.WriteLine("Segundo teste" & vbCrLf)
        While (i <= 10)

            Console.WriteLine($"Contador = {i}" & vbCrLf)
            If (i = 8) Then
                Continue While

            End If
            i += 1
        End While

        i = 0
        Console.WriteLine("Terceiro teste" & vbCrLf)
        While (i <= 10)
            Console.WriteLine($"Contador = {i}" & vbCrLf)
            If (i = 3) Then
                Exit While
            End If
            i += 1
        End While
    End Sub
End Module
