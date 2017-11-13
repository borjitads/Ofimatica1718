Option Strict On
Module Module1

    Sub Main()
        Dim matriz(16) As Integer

        '   Dim matriz2() As Integer = {1, 2, 3, 4, 5, 6}

        'Acceder a las posiciones:
        matriz(0) = 1
        matriz(2) = 9
        matriz(4) = 7
        matriz(6) = 3
        matriz(8) = -4
        Console.WriteLine("Capacidad de la matriz: " & matriz.Length)
        For i As Integer = 0 To matriz.Length - 1 Step 1
            Console.Write(matriz(i) & " ")
        Next

        For i As Integer = 9 To matriz.Length - 1 Step 1
            matriz(i) = 1
        Next

        Console.WriteLine("Array modificado con unos:")

        For i As Integer = 0 To matriz.Length - 1 Step 1
            Console.Write(matriz(i) & " ")
        Next

        Dim suma As Integer = 0

        For i As Integer = 0 To matriz.Length - 1 Step 1
            suma = suma + matriz(i)
        Next

        Console.WriteLine()
        Console.WriteLine("La suma es : " & suma)

        Console.ReadLine()
    End Sub

End Module
