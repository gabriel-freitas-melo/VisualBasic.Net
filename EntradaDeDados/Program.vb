Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Resgistros do usu�rio:")
        Dim nome As String
        Dim idade As Integer
        Console.Writeline("Digite seu nome:")
        nome = Console.ReadLine()
        Console.WriteLine("Digite a sua idade:")
        idade = Console.ReadLine()
        Console.WriteLine($"Ol� {nome}, voc� tem {idade} anos")
        Console.WriteLine("Digite enter para sair do programa")
        Console.ReadLine()
        Console.WriteLine("At� logo")
        Console.WriteLine("Fim do programa")


    End Sub
End Module
