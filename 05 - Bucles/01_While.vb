Option Strict On
Module Module1

    Sub Main()
        '15,30,45,60,75,90,105
        Dim i As Integer

        'inicializo variable de control
        i = 15
        Console.ForegroundColor = ConsoleColor.White

        While i <= 105
            Console.Write(i & " ")
            i += 15
        End While
        Console.WriteLine()
        '100,90,80,70,60
        i = 100

        While i >= 60
            Console.Write(i & " ")
            i -= 10
        End While
        Console.WriteLine()
        Dim n As Integer = 100

        i = 1

        While i <= n
            Console.Write(i & " ")
            i += 2
        End While
        Console.ReadLine()
    End Sub

End Module
