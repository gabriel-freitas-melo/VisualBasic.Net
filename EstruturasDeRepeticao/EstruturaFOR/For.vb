Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Estrutura FOR" & vbCrLf)

        'Estrutura do for 
        'For contador (as tipo) = inicio  To fim (step passos de 2 em 2 de 3 em 3 ...)
        '   comandos
        '   continue For -> interrompe aquela repeti��o e vai para proxima dentro do mesmo for
        '   exit For -> interrompe o la�o for como um todo
        '   Next (contador) -> encerramento do for normalmente sem interrup��es

        ' Obser��o: quebra de linhas em VB se faz uma concatena��o com & vbCrLf

        Dim i As Integer
        Console.WriteLine("Testando o continue for" & vbCrLf)
        For i = 1 To 15 Step 2
            If i = 9 Then
                Continue For
            Else
                Console.WriteLine($"Contador = {i}" & vbCrLf)
            End If

        Next
        Console.WriteLine("testando o exit for" & vbCrLf)
        For i = 1 To 15 Step 2
            If i = 11 Then
                Exit For
            Else
                Console.WriteLine($"Contador = {i}" & vbCrLf)
            End If

        Next




    End Sub
End Module
