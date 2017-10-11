Option Strict On
Module Module1

    Sub Main()
        Dim situacionLaboral As Integer
        Dim prestacion As String

        Console.WriteLine("Introduzca situación laboral: ")
        Console.WriteLine("1. Empleado cuenta ajena")
        Console.WriteLine("2. Autónomo")
        Console.WriteLine("3. En el paro")
        situacionLaboral = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("CObra alguna prestación del estado? s/n")
        prestacion = Console.ReadLine()

        If situacionLaboral = 1 Or situacionLaboral = 3 And prestacion = "n" Then
            Console.WriteLine("Puede cobrar la ayuda")
        Else
            Console.WriteLine("No cobra nada.")
        End If

        Console.ReadLine()


    End Sub

End Module
