Option Strict On
Module Module1

    Sub Main()
        Dim radio As Double
        Dim longitud, volumen, area As Double
        Const PI As Double = 3.1415

        'Solicitar por teclado el radio
        Console.WriteLine("Introduzca un radio: ")
        radio = Convert.ToDouble(Console.ReadLine())

        longitud = 2 * PI * radio
        area = PI * Math.Pow(radio, 2)
        volumen = (4 / 3) * PI * Math.Pow(radio, 3)

        'Redondear el valor de volumne a dos decimales-->
        volumen = Math.Round(volumen, 2)

        Console.WriteLine("Longitud: " & longitud)
        Console.WriteLine("Area: " & area)
        Console.WriteLine("Volumen: " & Math.Round(volumen, 2))
        Console.WriteLine(" Volumen: " & volumen)








        Console.ReadLine()
    End Sub

End Module
