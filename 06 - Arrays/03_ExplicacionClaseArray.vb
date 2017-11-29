Option Strict On
Module Module1

    Sub Main()

        Dim numeros() As Integer = {4, 5, 6, 7, 8, 1}
        Dim alumnos1GMI() As String = {"Moreira Alvaro", "Maya Francisco", "Almeida Yago", "Gestido Raúl"}
        Array.Sort(numeros)
        Array.Sort(alumnos1GMI)

        'For each: Recorrer matrices
        Console.WriteLine("Matriz numeros ordenada:")
        For Each numero As Integer In numeros
            Console.Write(numero & " ")
        Next
        Console.WriteLine("Alumnos GMI Ordenados alfabéticamente :")

        For Each alumno As String In alumnos1GMI
            Console.WriteLine(alumno)
        Next

        'Buscar a un alumno
        Dim alumnoABuscar As String = "Almeida Yago"
        Dim encontrado As Boolean = False
        'Saber si está o no está
        For Each a As String In alumnos1GMI
            If a = alumnoABuscar Then
                encontrado = True
                Console.WriteLine("Estáaaaaaaa!!!")
                Exit For
            End If
        Next

        If Not encontrado Then
            Console.WriteLine("No estááaaaaaa")
        End If

        Dim i As Integer
        'Si necesito saber posición
        For i = 0 To alumnos1GMI.Length - 1 Step 1
            If alumnos1GMI(i) = alumnoABuscar Then
                Console.WriteLine("Está en la pos " & i)
                Exit For
            End If
        Next

        If i = alumnos1GMI.Length Then
            Console.WriteLine("No está")
        End If

        'Otras FUNCIONES CLASE ARRAY
        Dim a1() As Integer = {9, 4, 7, 3, 2}
        Dim a2(a1.Length - 1) As Integer


        Array.Copy(a1, a2, a1.Length)

        'Comprobar
        Console.WriteLine("***** ARRAY COPY *******")
        For Each numero As Integer In a2
            Console.Write(numero & " ")
        Next
        Console.WriteLine()
        Array.Clear(a2, 0, a2.Length)
        Console.WriteLine("***** ARRAY COPY VERSIÓN 2 *******")
        Array.Copy(a1, 2, a2, 0, 2)

        For Each numero As Integer In a2
            Console.Write(numero & " ")
        Next

        Console.WriteLine()
        Console.WriteLine(" BINARY SEARCH")
        'Función BinarySearch : El array debe de estar ordenado previamente
        Dim matriz() As Integer = {9, 7, 3, 0, 4}
        Dim numeroABuscar As Integer = 10

        Array.Sort(matriz)
        Dim posicion As Integer = Array.BinarySearch(matriz, numeroABuscar)

        If posicion < 0 Then
            Console.WriteLine("No está")
        Else
            Console.WriteLine(numeroABuscar & " Está en " & posicion)
        End If




        Console.ReadLine()


    End Sub

End Module
