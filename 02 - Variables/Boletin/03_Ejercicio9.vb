Option Strict On
Module Module1

    Sub Main()
        Dim x, y, auxiliar As Integer

        x = 123456
        y = 2

        auxiliar = x
        x = y
        y = auxiliar

        Console.WriteLine("X = " & x)
        Console.WriteLine("Y = " & y)
        Console.ReadLine()


    End Sub

End Module
