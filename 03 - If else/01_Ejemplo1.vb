Module Module1

    Sub Main()
        Dim n1, n2 As Integer
        Dim mayor As Boolean

        n1 = 30
        n2 = 4

        mayor = n1 > n2

        If n1 > n2 Then
            Console.WriteLine(Math.Pow(n1, n2))
        End If
        If n1 <= n2 Then
            Console.WriteLine(Math.Pow(n2, n1))
        End If

        Console.ReadLine()
    End Sub

End Module
