Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("OR ELSE se a primeira condição for true nem analisa a segunda")
        Dim a, b, c As Integer
        a = 10
        b = 8
        c = 6
        Dim resultado As Boolean

        Console.WriteLine("Primeiro teste")
        If (a > b OrElse b > c) Then
            Console.WriteLine(a > b)
            Console.WriteLine(b > c)
            resultado = True
            Console.WriteLine(resultado)
        End If

        a = 8
        b = 6
        c = 10

        Console.WriteLine("Segundo teste")
        If (a > b OrElse b > c) Then
            Console.WriteLine(a > b)
            Console.WriteLine(b > c)
            resultado = True
            Console.WriteLine(resultado)
        End If

        a = 6
        b = 8
        c = 10

        Console.WriteLine("Segundo teste")
        If (a > b OrElse b > c) Then
            Console.WriteLine(a > b)
            Console.WriteLine(b > c)
            resultado = True
            Console.WriteLine(resultado)
        End If
    End Sub
End Module
