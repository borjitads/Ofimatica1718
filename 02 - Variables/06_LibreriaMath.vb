Option Strict On
Module Module1

    Sub Main()
        Dim numero As Integer
        Dim raiz As Single

        'Ejemplo de Math.sqrt para calcular raices cuadradas
        numero = 99
        raiz = Convert.ToSingle(Math.Sqrt(numero))
        ' raiz = Convert.ToSingle(Math.Round(raiz, 2))
        Console.WriteLine("La raiz de " & numero & " es : " & Math.Round(raiz, 2))
        Console.WriteLine("Sin redondear: " & raiz)
        'Ejemplo de Math.pow para potecias 
        Dim x As Integer = 9
        Dim potencia As Long

        potencia = Convert.ToInt64(Math.Pow(x, 5))
        Console.WriteLine("X elevado a 5 es: " & potencia)
        Console.ReadLine()
    End Sub

End Module
