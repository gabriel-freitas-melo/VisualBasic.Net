Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Estrutura FOR EACH")
        'Essa estrutura executa uma condição para cada elemento da coleção(listas filas árvores ...)
        'For Each elemento (as tipo) in grupo
        '   comando
        '   Continue For
        '   Exit For
        'Next elemento
        Dim lista As New List(Of String) From {"Golf", "Gtr-R35", "Audi A3"}
        'Caracterizei a lista como sendo um catálogo de carros
        For Each carro As String In lista
            Console.WriteLine(carro)
        Next
    End Sub
End Module
