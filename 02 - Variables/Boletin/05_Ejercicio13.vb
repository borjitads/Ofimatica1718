Option Strict On
Module Module1

    Sub Main()
        Dim cateto1, cateto2 As Double
        Dim hipotenusa As Double

        'Solicitar al usuario que introduzca los catetos
        Console.WriteLine("Introduzca el primer lado:")
        cateto1 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Introduzca segundo lado")
        cateto2 = Convert.ToDouble(Console.ReadLine())

        hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2))
        hipotenusa = Math.Round(hipotenusa, 2)
        Console.WriteLine("La hipotenusa es: " & hipotenusa)

        Console.ReadLine()


    End Sub

End Module
