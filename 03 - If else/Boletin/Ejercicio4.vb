Option Strict On
Module Module1

    Sub Main()
        Dim a, b, c, d, menor As Integer

        a = -33
        b = -9
        c = -10
        d = -300

        If a > b Then
            menor = b
        Else
            menor = a
        End If

        If menor > c Then
            menor = c
        End If

        If menor > d Then
            menor = d
        End If

        Console.WriteLine("El menor es: " & menor)
        Console.ReadLine()
    End Sub

End Module
