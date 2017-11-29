Option Strict On

Module Module1

    Sub Main()
        Dim ejercicio As Integer = 11

        Select Case ejercicio
            Case 1
                Dim matriz(9) As Short
                matriz(0) = 1
                matriz(1) = 4
                matriz(3) = 9

                For i As Integer = 0 To matriz.Length - 1 Step 1
                    Console.Write(matriz(i) & " ")
                Next

                Console.WriteLine("Introduzca un valor y se lo guardo en la última posición")
                matriz(matriz.Length - 1) = Convert.ToInt16(Console.ReadLine())

                Console.WriteLine("La última position vale: " & matriz(matriz.Length - 1))

            Case 3
                Dim array() As Integer = {200, 6, 5, 4, 4, 5, 6, 7}
                Dim desviaciones(array.Length - 1) As Integer
                Dim suma, sumaDesviaciones As Integer
                Dim media, desviacionMedia As Double

                Console.WriteLine("Capacidad Matriz: " & array.Length)
                Console.WriteLine("Primera posicion:")
                Console.WriteLine(array(0))
                Console.WriteLine("Ultima posicion:")
                Console.WriteLine(array(array.Length - 1))

                For i As Integer = 0 To array.Length - 1 Step 1
                    suma = suma + array(i)
                Next

                media = suma / array.Length

                'Desviación : Abs(valor - media)


                For i As Integer = 0 To array.Length - 1 Step 1
                    Dim desviacion As Integer = Convert.ToInt32(Math.Abs(array(i) - media))
                    '  desviaciones(i) = Convert.ToInt16(Math.Abs(array(i) - media))
                    Console.WriteLine("Desviación x(" & i & "): " & desviacion)
                    sumaDesviaciones = sumaDesviaciones + desviacion
                Next

                desviacionMedia = sumaDesviaciones / array.Length
                Console.WriteLine()
                Console.WriteLine("La desviación media es: " & desviacionMedia)

            Case 4
                Dim n As Integer
                Dim negativos As Boolean
                Console.WriteLine("Introduzca un tamaño: ")
                n = Convert.ToInt32(Console.ReadLine())

                Dim array(n - 1) As Integer

                For i As Integer = 0 To array.Length - 1 Step 1
                    Console.WriteLine("Introduzca valor posición: " & i)
                    array(i) = Convert.ToInt32(Console.ReadLine())
                Next
                Console.WriteLine()
                Console.WriteLine("Números negativos y sus pos:")
                For i As Integer = 0 To array.Length - 1 Step 1
                    If array(i) < 0 Then
                        Console.WriteLine(array(i) & " pos: " & i)
                        negativos = True
                    End If
                Next

                If Not negativos Then
                    Console.WriteLine("No hay números negativos")
                End If

            Case 8
                Dim x, i As Integer
                Console.WriteLine("Intro numero elementos")
                x = Convert.ToInt32(Console.ReadLine())
                'Doy tamaño a la matriz
                Dim datos(x - 1) As Integer

                For i = 0 To datos.Length - 1 Step 1
                    Console.WriteLine("Intro valor posicion: " & i)
                    datos(i) = Convert.ToInt32(Console.ReadLine())
                Next

                'Solicitar al usuario que escoja un elemento
                Dim posUsuario As Integer
                Do
                    Console.WriteLine("Escoja posición para intercambiar con último elemento")
                    posUsuario = Convert.ToInt32(Console.ReadLine())
                Loop While posUsuario < 0 Or posUsuario > datos.Length - 1
                'Mostrar array
                Console.WriteLine("Array original")
                For j As Integer = 0 To datos.Length - 1 Step 1
                    Console.Write(datos(j) & " ")
                Next
                Console.WriteLine()
                'Intercambiar posicion 
                Dim auxiliar As Integer = datos(posUsuario)
                datos(posUsuario) = datos(datos.Length - 1)
                datos(datos.Length - 1) = auxiliar

                Console.WriteLine("Array modificado")
                For j As Integer = 0 To datos.Length - 1 Step 1
                    Console.Write(datos(j) & " ")
                Next
                Console.ReadLine()


            Case 10
                Dim numeros(20) As Integer
                Dim encontrado As Boolean = False
                ''Llenar de números aleatorios
                Dim aleatorio As Random = New Random()

                For j As Integer = 0 To numeros.Length - 1 Step 1
                    numeros(j) = aleatorio.Next(0, 50)
                Next

                For j As Integer = 0 To numeros.Length - 1 Step 1
                    Console.Write(numeros(j) & " ")
                Next
                Console.WriteLine()
                Dim valorBuscado As Integer
                Console.WriteLine("Introduzca un número menor que 50")
                valorBuscado = Convert.ToInt32(Console.ReadLine())

                For j As Integer = 0 To numeros.Length - 1 Step 1
                    If numeros(j) = valorBuscado Then
                        Console.WriteLine("Posición: " & j)
                        encontrado = True
                        '  Exit For
                    End If
                Next

                If Not encontrado Then
                    Console.WriteLine("No está el número en la matriz")
                End If
                Console.ReadLine()
            Case 11
                Dim m1() As Integer = {5, 9, 8, 1, 2, 3}
                Dim m2(m1.Length - 1) As Integer

                Array.Copy(m1, m2, m1.Length)

                Array.Sort(m1)

                Dim valor As Integer = 8
                Dim posOrdenado As Integer = Array.BinarySearch(m1, valor)

                If posOrdenado < 0 Then
                    Console.WriteLine(valor & " no está en la matriz")
                Else
                    Console.WriteLine(valor & " Posición ordenada: " & posOrdenado)
                End If

                Dim posOriginal As Integer = -1
                'Búsqueda matriz no ordenada
                For i As Integer = 0 To m2.Length - 1 Step 1
                    If m2(i) = valor Then
                        posOriginal = i
                        Exit For
                    End If
                Next

                If posOriginal = -1 Then
                    Console.WriteLine("No está en la matriz ")
                Else
                    Console.WriteLine(valor & " está en " & posOriginal)
                End If

                Console.WriteLine("Matriz ordenada")

                For Each n As Integer In m1
                    Console.Write(n & " ")
                Next

                Console.WriteLine()

                Console.WriteLine("Matriz original: ")
                For Each n As Integer In m2
                    Console.Write(n & " ")
                Next

                Console.ReadLine()



            Case 12
                'Algoritmo de la burbuja, es un método de ordenación de datos

                Dim datos() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9}

                'Mostrar la matriz
                For j As Integer = 0 To datos.Length - 1 Step 1
                    Console.Write(datos(j) & " ")
                Next
                Console.WriteLine()
                For k As Integer = 0 To datos.Length - 1 Step 1
                    For j As Integer = 0 To datos.Length - 2 Step 1
                        If datos(j) < datos(j + 1) Then
                            Dim aux As Integer = datos(j)
                            datos(j) = datos(j + 1)
                            datos(j + 1) = aux
                        End If
                        '    Console.Write(datos(j) & " ")
                    Next
                    '

                Next
                'Mostrar la matriz
                For j As Integer = 0 To datos.Length - 1 Step 1
                    Console.Write(datos(j) & " ")
                Next
                Console.ReadLine()



            Case 13
                Dim temperaturas() As Integer = {7, 0, 30, 5, 1, 2}
                Dim maximo As Integer = temperaturas(0)
                Dim posicionMaximo As Integer
                For i As Integer = 1 To temperaturas.Length - 1 Step 1
                    If temperaturas(i) > maximo Then
                        maximo = temperaturas(i)
                        posicionMaximo = i
                    End If
                Next
                Console.WriteLine("Maximo valor " & maximo & " en posición " & posicionMaximo)
                Console.ReadLine()
            Case 14

                Dim matriz() As Integer = {8, 7, 13, 23, 40}
                Dim contadorDivisores, contadorPrimos As Integer
                Dim j As Integer
                For k As Integer = 0 To matriz.Length - 1 Step 1
                    contadorDivisores = 0
                    For j = 2 To matriz(k) - 1 Step 1
                        If matriz(k) Mod j = 0 Then
                            contadorDivisores += 1
                            Exit For
                        End If
                    Next
                    If contadorDivisores = 0 Then
                        Console.WriteLine(matriz(k) & " es Numero primo")
                        contadorPrimos += 1
                    End If
                Next

                Console.WriteLine("Hay " & contadorPrimos & " numeros primos.")






                Console.ReadLine()
        End Select
    End Sub

End Module
