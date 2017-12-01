Option Strict On
Module Module1

    Sub Main()
        'Ejercicio 1: Mostrar numeros por consola
        'Mostrar todos los números hasta el 100: 1,2,3,4 ... 100

        Dim i As Integer

        i = 1

        While i <= 100
            Console.Write(i & " ")
            i = i + 1
        End While
        Console.WriteLine()
        Console.WriteLine("Números pares: ")

        i = 0

        While i <= 50

            Console.Write(i & " ")
            i = i + 2
        End While

        Console.WriteLine()
        Console.WriteLine("MÚLTIPLOS DE 3 Y 5")

        i = 1

        While i <= 100
            If i Mod 3 = 0 And i Mod 5 = 0 Then
                Console.Write(i & " ")
            End If

            i += 1
        End While

        'SUMAS
        'Ejercicio 2: Calcular la suma de los 100 primeros números
        Dim suma As Integer = 0

        i = 1

        While i <= 100
            suma = suma + i
            i += 1
        End While

        Console.WriteLine("La suma es: " & suma)
        Console.WriteLine()

        Console.WriteLine("Sumar valores impares")

        i = 1
        suma = 0
        While i <= 100
            suma = suma + i
            i = i + 2
        End While
        Console.WriteLine("La suma es : " & suma)

        Console.WriteLine()
        Console.WriteLine("SUMA MÚLTIPLOS DE 3 , 5 Y 7")

        i = 1
        suma = 0

        While i <= 1000
            If i Mod 3 = 0 And i Mod 5 = 0 And i Mod 7 = 0 Then
                suma = suma + i

            End If
            i += 1
        End While
        Console.WriteLine("La suma es: " & suma)


        'Ejercicio 3: CONTADORES
        'Contar divisores de un número n dado
        Dim n As Integer = 375
        Dim contadorDivisores As Integer

        i = 1

        While i <= n
            If n Mod i = 0 Then
                contadorDivisores += 1
            End If

            i = i + 1
        End While

        Console.WriteLine(n & " tiene " & contadorDivisores & " divisores.")

        'Número PRIMO
        Console.WriteLine()
        Console.WriteLine("NÚMERO PRIMO")

        Dim numero As Integer = 110
        Dim primo As Boolean = True
        contadorDivisores = 0

        i = 2

        While i < numero

            If numero Mod i = 0 Then
                contadorDivisores += 1
                primo = False
                Exit While
            End If
            i = i + 1
        End While

        If primo = True Then
            Console.WriteLine("Primo")
        Else
            Console.WriteLine("No primo")
        End If

        If contadorDivisores = 0 Then
            Console.WriteLine(numero & " es primo.")
        Else
            Console.WriteLine(numero & " no es primo.")
        End If

        'EJERCICIO: NÚMEROS PERFECTOS.
        'Un número es perfecto cuando la suma de sus divisores 
        'excepto el mismo , es igual al propio número

        Dim numeroPerfect As Integer = 288
        Dim sumaDiv As Integer = 0

        i = 1

        While i < numeroPerfect

            If numeroPerfect Mod i = 0 Then
                sumaDiv = sumaDiv + i
            End If
            i = i + 1
        End While

        If sumaDiv = numeroPerfect Then
            Console.WriteLine("Número perfecto")
        Else
            Console.WriteLine("No es perfect")
        End If

        'BUCLE FOR

        For j As Integer = 0 To 100 Step 1
            Console.Write(j & " ")
        Next






















        Console.ReadLine()


    End Sub

End Module
