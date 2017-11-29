Module Module1

    Sub Main()
        Dim dnis(2) As String
        Dim dni As String

        dnis(0) = "12345678U"
        dnis(1) = "99999999E"
        dnis(2) = "000000000W"
        Console.WriteLine("Introduzca un DNI")
        dni = Console.ReadLine
        Dim guardado As Boolean = False
        For i As Integer = 0 To dnis.Length - 1 Step 1
            If dnis(i) Is Nothing Then
                dnis(i) = dni
                guardado = True
                Exit For
            End If
        Next
        If Not guardado Then
            'Redimensionado
            ReDim Preserve dnis(dni.Length * 2)
            For i As Integer = 0 To dnis.Length - 1 Step 1
                If dnis(i) Is Nothing Then
                    dnis(i) = dni
                    guardado = True
                    Exit For
                End If
            Next
        End If


        'Comprobar mostrando por pantalla

        For Each dato As String In dnis
            If dato = Nothing Then
                Exit For
            Else
                Console.WriteLine(dato)
            End If

        Next

        Console.ReadLine()
    End Sub

End Module
