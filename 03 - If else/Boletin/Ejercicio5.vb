Option Strict On
Module Module1

    Sub Main()
        Dim presion, temperatura As Double

        presion = 1
        temperatura = 300

        If presion > 2 Then
            Console.WriteLine("Reducir presión del núcleo")
        End If

        If temperatura > 500 Then
            Console.WriteLine("Reducir temperatura")
        End If

        If presion < 2 And temperatura < 500 Then
            Console.WriteLine("Todo en orden")
        End If

        Console.ReadLine()
    End Sub

End Module
