Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Estrutura DO-WHILE")
        'Útil para uma repetição indefinida de vezes
        'Normalmente a condição a ser testada for no final pelo menos uma vez o loop é executado
        'Do
        '   comandos
        '   Continue DO
        '   Exit DO
        'Loop {While|Until} condição --> se usar o until em vez de while é a condição oposta
        Dim i As Integer
        i = 0
        Do
            If i = 8 Then
                Exit Do
            End If
            Console.Write($"Contador = {i}" & vbCrLf)
            i += 1
        Loop While i <= 10


    End Sub
End Module
