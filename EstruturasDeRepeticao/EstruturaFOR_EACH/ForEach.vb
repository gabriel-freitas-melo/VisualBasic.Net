Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Estrutura FOR EACH")
        'Essa estrutura executa uma condi��o para cada elemento da cole��o(listas filas �rvores ...)
        'For Each elemento (as tipo) in grupo
        '   comando
        '   Continue For
        '   Exit For
        'Next elemento
        Dim lista As New List(Of String) From {"Golf", "Gtr-R35", "Audi A3"}
        'Caracterizei a lista como sendo um cat�logo de carros
        For Each carro As String In lista
            Console.WriteLine(carro)
        Next
    End Sub
End Module
