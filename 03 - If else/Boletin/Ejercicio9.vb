Module Module1

    Sub Main()
        Dim n1, n2 As Integer

        'Inicializamos las variables
        n1 = 30
        n2 = 4
        'Comprobamos cuál es mayor
        If n1 > n2 Then
            Console.WriteLine(Math.Pow(n1, n2))
        Else

            Console.WriteLine(Math.Pow(n2, n1))
        End If

        Console.ReadLine()
    End Sub

End Module
