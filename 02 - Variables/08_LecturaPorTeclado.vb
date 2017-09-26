Option Strict On
Module Module1

    Sub Main()
        'Lectura de datos por teclado
        Dim precioInicial, precioFinal As Double
        Dim rebaja As Byte
        Dim codigoVendedor As String
        Console.WriteLine("Codigo vendedor:")
        codigoVendedor = Console.ReadLine()

        Console.WriteLine("Introduzca el precio del producto: ")
        precioInicial = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Introduzca la rebaja que se debe aplicar: ")
        rebaja = Convert.ToByte(Console.ReadLine())

        precioFinal = precioInicial - (rebaja / 100) * precioInicial

        Console.WriteLine("El precio final es " & precioFinal)
        Console.ReadLine()





    End Sub

End Module
