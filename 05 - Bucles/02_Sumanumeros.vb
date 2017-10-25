Option Strict On
Module Module1

    Sub Main()
        Dim n, i, suma As Integer
        n = 100
        'suma = 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9

        i = 1

        While i <= n

            suma = suma + i
            i += 1
        End While
        Console.WriteLine("La suma es: " & suma)
        Console.ReadLine()
    End Sub

End Module
