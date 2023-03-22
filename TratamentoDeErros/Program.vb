Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Tratamento de erros")
        'Sintaxe:
        'Try
        '   Comandos
        '   Exit Try
        'Catch exce��o as tipo When express�o
        '   Comandos
        '   Exit Try
        'Finally
        '   Comando finally(Sempre ser�o executados tendo ou n�o excess�o)
        '---------------------------------------
        'Ir� ser feita a captura da excess�o e expor a sua mensagem relacionada
        'Al�m ir� mostrar o Stack Trace (Lista de m�todos em execu��o quando o erro aconteceu)
        'Essas duas propriedades facilitam o rastreamento do erro
        '---------------------------------------
        Dim x, y As Double
        x = 8
        y = Nothing

        Try
            CriandoExececao()
        Catch ex As Exception 'Armazena qualquer tipo de exception pois n�o expecificou uma
            Console.WriteLine("Messagem: " & ex.Message)
            Console.WriteLine("StackTrace: " & vbCrLf & ex.StackTrace)
        Finally
            Console.WriteLine("Fim da execu��o")

        End Try
        'Pode Criar esse tratamento dentro de um Loop
        'e que haja sempre o tratamento caso um valor seja executado de maneira errada
    End Sub
    Sub CriandoExececao() 'Abrir para leitura um arquivo que n�o existe
        Dim sr As System.IO.StreamReader = System.IO.File.OpenText("bdfjbdf.txt")
        Console.Writeline(sr.ReadToEnd)
        sr.Close()
    End Sub
End Module
