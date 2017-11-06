Option Strict On
Module Module1

    Sub Main()
        Dim i, j As Integer

        For i = 1 To 5 Step 1
            For j = 1 To 5 Step 1
                Console.Write("* ")
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()
        Console.WriteLine("CON BUCLE WHILE: ")
        Console.WriteLine()
        i = 1

        While i < 3
            j = 1
            While j < 3
                Console.Write("* ")
                j += 1
            End While
            Console.WriteLine()
            i += 1
        End While

        Console.ReadLine()
    End Sub

End Module
