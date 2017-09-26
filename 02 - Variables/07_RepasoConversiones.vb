Option Strict On
Module Module1

    Sub Main()
        'Repaso Conversiones de tipos
        'Conversiones implícitas: No dan problemas, se guarda una variable
        'en otra de mayor tamaño
        Dim n1, n2 As Byte
        n1 = 100
        n2 = 150
        Dim n3 As Integer = n1 'Guardamos en un Integer el valor de un byte

        'Conversiones explícitas: 
        Dim numero As Double = 13.893734
        Dim resultado As Single = Convert.ToSingle(numero)
        'Dan dos problemas
        '1) Pérdida de precisión
        Dim raiz As Double = Math.Sqrt(7)
        Dim raizEntera As Integer = Convert.ToInt32(raiz)
        '2)Desbordamiento
        Dim x As Byte = 200
        Dim y As Byte = Convert.ToByte(x + 100)


    End Sub

End Module
