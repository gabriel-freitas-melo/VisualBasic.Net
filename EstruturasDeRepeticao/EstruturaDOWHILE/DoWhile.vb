Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Estrutura DO-WHILE")
        '�til para uma repeti��o indefinida de vezes
        'Normalmente a condi��o a ser testada for no final pelo menos uma vez o loop � executado
        'Do
        '   comandos
        '   Continue DO
        '   Exit DO
        'Loop {While|Until} condi��o --> se usar o until em vez de while � a condi��o oposta
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
