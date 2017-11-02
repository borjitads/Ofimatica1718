Option Strict On
Module Module1

    Sub Main()
        Dim numero, contador, i As Integer

        Do
            Console.WriteLine("Introduzca un numero positivo mayor que 2")
            numero = Convert.ToInt32(Console.ReadLine())
        Loop While numero <= 2

        contador = 2
        i = 2
        While i < numero
            If numero Mod i = 0 Then
                contador = contador + 1

            End If
            i += 1
        End While
        Console.WriteLine(numero & " tiene " & contador & " divisores.")
        Console.ReadLine()


    End Sub

End Module
