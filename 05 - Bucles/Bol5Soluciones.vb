Option Strict On
Module Module1

    Sub Main()

        Dim ejercicio As Integer
        ejercicio = 21
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

            Case 21
                Dim i, j As Integer

                For j = 1 To 10 Step 1
                    Console.WriteLine("Tabla de multiplicar del : " & j)
                    For i = 1 To 10 Step 1
                        Console.WriteLine(j & " * " & i & " = " & j * i)
                    Next
                    Console.WriteLine()
                Next
                Console.ReadLine()
            Case 22
                Dim i, j, n As Integer

                For i = 7 To 1 Step -1
                    For j = 1 To i Step 1
                        Console.Write("* ")
                    Next
                    Console.WriteLine()
                Next

                'i = 1
                'While i <= 7
                '    For j = 7 To i Step -1
                '        Console.Write("* ")
                '    Next
                '    Console.WriteLine()
                '    i += 1
                'End While

                n = 7
                For i = 1 To 7 Step 1
                    For j = 1 To n Step 1
                        Console.Write("* ")
                    Next
                    n -= 1
                    Console.WriteLine()
                Next

                Console.WriteLine("Apartado C:")
                Console.WriteLine()


                For ii As Integer = 1 To 5 Step 1
                    For jj = 1 To ii Step 1
                        Console.Write("*")
                    Next
                    Console.WriteLine()
                Next

                For ii = 4 To 1 Step -1
                    For jj = 1 To ii Step 1
                        Console.Write("*")
                    Next
                    Console.WriteLine()
                Next

                Console.WriteLine()
                Console.WriteLine("Apartado D")

                For ii = 7 To 1 Step -1
                    For jj = 1 To ii Step 1
                        Console.Write(jj & " ")
                    Next
                    Console.WriteLine()
                Next




                Console.ReadLine()
            Case 23
                Dim numero As Long = 100
                Dim i, j, suma As Long

                For j = 1 To numero Step 1
                    suma = 0
                    For i = 1 To j - 1 Step 1
                        If j Mod i = 0 Then
                            suma = suma + i
                        End If
                    Next
                    If suma = j Then
                        Console.WriteLine(j & " es perfecto")
                    Else
                        Console.WriteLine("Calculando...")

                    End If
                Next
            Case 24
                Dim numero As Integer = 2000000
                Dim i, j As Integer
                Dim cuentaPrimos, cuentaDivisores As Integer
                Dim primo As Boolean = True
                'Número primo si tiene 2 divisores : el 1 y si mismo

                For j = 3 To numero Step 1
                    primo = True
                    For i = 2 To j - 1 Step 1
                        If j Mod i = 0 Then
                            'cuentaDivisores += 1
                            primo = False
                            Exit For
                        End If
                    Next

                    If primo Then
                        Console.WriteLine(j & " es primo.")
                    End If
                Next

                Console.ReadLine()
            Case 25
                'Generación números aleatorios
                Dim rand As Random = New Random()
                For j As Integer = 0 To 100 Step 1
                    For i As Integer = 0 To 10 Step 1
                        Dim n As Integer = rand.Next(1, 10)
                        Console.Write(n & " ")
                    Next
                    Console.WriteLine()
                Next


        End Select

        Dim h, m As Integer
        h = 10
        m = 20
        While h < m
            h += 1
            m = m - 2
        End While
        Console.WriteLine(h)
        Console.ReadLine()


    End Sub

End Module
