
Module Module1

    Sub Main()
        'La longitud de una circunferencia a partir del radio
        'longitud = 2*Pi*radio
        Const PI As Double = 3.141596
        Dim longitud, radio As Single

        'Leer radio
        radio = 109
        longitud = 2 * PI * radio

        Console.WriteLine("La longitud de la circuferencia
         con radio " & radio & " es " & longitud)

        Console.ReadLine()


    End Sub

End Module
