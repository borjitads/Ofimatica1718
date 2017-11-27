Option Strict On

Module Module1

    Sub Main()
        Dim ejercicio As Integer = 12

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

            Case 12
                'Algoritmo de la burbuja, es un método de ordenación de datos

                Dim datos() As Integer = {5, 9, 0, 3, 1, 8, 2}

                'Mostrar la matriz
                For j As Integer = 0 To datos.Length - 1 Step 1
                    Console.Write(datos(j) & " ")
                Next
                Console.WriteLine()

                For j As Integer = 0 To datos.Length - 2 Step 1
                    If datos(j) < datos(j + 1) Then
                        Dim aux As Integer = datos(j)
                        datos(j) = datos(j + 1)
                        datos(j + 1) = aux
                    End If
                Next

                'Mostrar la matriz
                For j As Integer = 0 To datos.Length - 1 Step 1
                    Console.Write(datos(j) & " ")
                Next
                Console.ReadLine()








                Console.ReadLine()
        End Select
    End Sub

End Module
