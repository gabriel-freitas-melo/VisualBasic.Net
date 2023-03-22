Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Tratamento de erros")
        'Sintaxe:
        'Try
        '   Comandos
        '   Exit Try
        'Catch exceção as tipo When expressão
        '   Comandos
        '   Exit Try
        'Finally
        '   Comando finally(Sempre serão executados tendo ou não excessão)
        '---------------------------------------
        'Irá ser feita a captura da excessão e expor a sua mensagem relacionada
        'Além irá mostrar o Stack Trace (Lista de métodos em execução quando o erro aconteceu)
        'Essas duas propriedades facilitam o rastreamento do erro
        '---------------------------------------
        Dim x, y As Double
        x = 8
        y = Nothing

        Try
            CriandoExececao()
        Catch ex As Exception 'Armazena qualquer tipo de exception pois não expecificou uma
            Console.WriteLine("Messagem: " & ex.Message)
            Console.WriteLine("StackTrace: " & vbCrLf & ex.StackTrace)
        Finally
            Console.WriteLine("Fim da execução")

        End Try
        'Pode Criar esse tratamento dentro de um Loop
        'e que haja sempre o tratamento caso um valor seja executado de maneira errada
    End Sub
    Sub CriandoExececao() 'Abrir para leitura um arquivo que não existe
        Dim sr As System.IO.StreamReader = System.IO.File.OpenText("bdfjbdf.txt")
        Console.Writeline(sr.ReadToEnd)
        sr.Close()
    End Sub
End Module
