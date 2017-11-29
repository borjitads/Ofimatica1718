Option Strict On
Module Module1

    Sub Main()
        Dim x() As Integer = {3, 4, 5, 6, 7, 9, 0, 7, 1}

        'Ejercicio : Crear una copia de la matriz x
        Dim y(x.Length - 1) As Integer

        y(0) = x(0)
        y(1) = x(1)
        y(2) = x(2)

        For i As Integer = 0 To x.Length - 1 Step 1
            y(i) = x(i)
        Next

        'Ejercicio 2: Comparación de arrays

        Dim k() As Integer = {4, 5, 6, 7, 8}
        Dim z() As Integer = {4, 5, 6, 3, 1}
        Dim distintos As Boolean = False
        For h As Integer = 0 To k.Length - 1 Step 1
            If k(h) <> z(h) Then
                distintos = True
                Exit For
            End If
        Next

        If distintos = True Then
            Console.WriteLine("Son distintos.")
        Else
            Console.WriteLine("Son iguales.")
        End If

        Console.ReadLine()


        '  Console.WriteLine(y(1))
        Console.ReadLine()

    End Sub

End Module
