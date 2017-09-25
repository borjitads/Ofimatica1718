Option Strict On
Module Module1

    Sub Main()
        Dim contador As Byte = 60
        ' contador = 255
        'Conversiones explícitas : Clase Convert
        contador = Convert.ToByte(contador + 1)

        'Conversiones implícitas
        'Byte guardado en Short
        Dim loquesea As Short = contador



    End Sub

End Module
