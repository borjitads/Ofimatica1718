Option Strict On
Module Module1

    Sub Main()
        Dim contrasena1, contrasena2 As String
        Dim aceptado As Boolean = False

        Console.WriteLine("Introduzca su contraseña")
        contrasena1 = Console.ReadLine()

        Console.WriteLine("Introduzca otra vez su contraseña:")
        contrasena2 = Console.ReadLine()


        If contrasena1 = contrasena2 Then
            aceptado = True
        Else
            aceptado = False
        End If

        If aceptado Then
            Console.WriteLine("Estás dentro")
        Else
            Console.WriteLine("Contraseñas erróneas")
        End If
        Console.ReadLine()








    End Sub

End Module
