Option Strict On
Module Module1

    Sub Main()

        Dim ejercicio As Integer
        ejercicio = 11
        Select Case ejercicio
            Case 5
                Dim i As Integer

                i = 320

                While i > 160
                    Console.Write(i & " ")
                    i = i - 20
                End While
                Console.ReadLine()
            Case 6
                For i = 1 To 100 Step 5

                    Console.WriteLine(i)
                Next
                Console.ReadLine()
            Case 7
                Dim n As Integer
                'Tabla multiplicar
                n = 3

                Console.WriteLine("Tabla del " & n)

                For i = 1 To 10 Step 1
                    Console.WriteLine(n & " * " & i & " = " & n * i)
                Next
            Case 8
                Dim n As Integer
                n = 10
                Dim i As Integer = n

                While i < n + 5
                    Console.WriteLine(i & " " & Math.Pow(i, 2) & " " & Math.Pow(i, 3))
                    i += 1
                End While
                Console.ReadLine()
            Case 9
                Dim i As Double

                For i = 16 To 1 Step -2.5
                    Console.WriteLine(i & " " & Math.Round(Math.Sqrt(i), 2))
                Next
                Console.ReadLine()
            Case 10

                Dim nn As Integer
                Dim i, suma As Integer

                Do
                    Console.WriteLine("Intro un número positivo:")
                    nn = Convert.ToInt32(Console.ReadLine())
                Loop While nn < 0

                suma = 0
                i = 1
                While i <= nn

                    i += 1
                End While
                Console.WriteLine("Suma: " & suma)

                For i = 1 To nn Step 1
                    suma = suma + i
                Next

                Console.ReadLine()
            Case 11
                Dim i = 1, num As Integer
                Dim suma As Double
                num = 1000

                For i = 1 To num Step 1
                    suma += 1 / Math.Pow(i, 3)
                Next

                Console.WriteLine("La suma es: " & suma)
                Console.ReadLine()
            Case 12
                Dim numero, suma, i As Integer

                'Número tiene que ser positivo
                Do
                    Console.WriteLine("Intro numero positivo")
                    numero = Convert.ToInt32(Console.ReadLine())
                Loop While numero < 0

                i = 1

                While i < numero
                    If numero Mod i = 0 Then
                        suma = suma + i
                    End If
                    i = i + 1
                End While
            Case 13
                Dim numero, suma, i As Integer

                'Número tiene que ser positivo
                Do
                    Console.WriteLine("Intro numero positivo")
                    numero = Convert.ToInt32(Console.ReadLine())
                Loop While numero < 0

                i = 1

                While i < numero
                    If numero Mod i = 0 Then
                        suma = suma + i

                    End If
                    i = i + 1
                End While

                If suma = numero Then
                    Console.WriteLine("Número perfecto")
                Else
                    Console.WriteLine("No es perfecto")
                End If
                Console.ReadLine()
            Case 16
                Dim n As Integer = 5
                Dim fact As Long = 1

                For i As Integer = 1 To n Step 1
                    fact = fact * i

                Next
                Console.WriteLine("Factorial : " & fact)
                Console.ReadLine()

            Case 18
                Console.WriteLine("Introduzca un numero")
                Dim n As Integer = Convert.ToInt32(Console.ReadLine())
                Dim contador As Integer = 0

                Dim i As Integer

                For i = 2 To n - 1 Step 1
                    If n Mod i = 0 Then
                        contador += 1
                    End If
                Next

                Console.WriteLine("Tiene " & contador & " divisores.")
                Console.ReadLine()

            Case 19
                Console.WriteLine("Introduzca un numero")
                Dim n As Integer = Convert.ToInt32(Console.ReadLine())
                Dim contador As Integer = 0
                Dim i As Integer
                Dim primo As Boolean = True
                For i = 2 To n - 1 Step 1
                    If n Mod i = 0 Then
                        primo = False
                        Exit For
                    End If
                Next
                If primo Then
                    Console.WriteLine("PRimoooooooooooooo")
                Else
                    Console.WriteLine("No primooooooooooo")
                End If
                Console.ReadLine()

            Case 20
                Dim n1, n2, i, contador As Integer
                Dim multiplo As Boolean = False
                n1 = 50
                n2 = 100
                contador = 0
                i = n1

                While i <= n2
                    If i Mod 3 = 0 And i Mod 5 = 0 And i Mod 7 = 0 Then
                        Console.WriteLine(i)
                        multiplo = True
                        Exit While
                    End If

                    i += 1
                End While

                If Not multiplo Then
                    Console.WriteLine("No hay multiplos.")
                End If
                Console.ReadLine()




        End Select
        Console.ReadLine()

    End Sub

End Module
