Module Module1

    Sub Main()
        'Ejercicio: Calcular area triángulo a partir de base y de altura
        'Declaración de Variables
        Console.ForegroundColor = ConsoleColor.White
        Dim base, altura, areaTriangulo As Single

        'Inicialización de las variables
        base = 10.5899
        altura = 5

        areaTriangulo = (base * altura) / 2


        ' Console.WriteLine("El área del triángulo es : " & areaTriangulo)
        Console.WriteLine("El area del triangulo es ")
        Console.WriteLine(Math.Round(areaTriangulo, 2))
        Console.ReadLine()




    End Sub

End Module
