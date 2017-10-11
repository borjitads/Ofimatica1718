Option Strict On
Module Module1

    Sub Main()
        Dim resCelta, resMadrid, resFeliz As String

        Console.WriteLine("Es usted socio del Celta? s/n")
        resCelta = Console.ReadLine()

        Console.WriteLine("Es usted seguidor del Madrid? s/n")
        resMadrid = Console.ReadLine()

        Console.WriteLine("Es usted feliz? s/n")
        resFeliz = Console.ReadLine()

        If (resCelta = "s" Or resMadrid = "s" Or resMadrid = "S") And resFeliz = "s" Then
            Console.WriteLine("Enhorabuena")
        Else
            Console.WriteLine("Menudo lío")
        End If
        Console.ReadLine()
    End Sub

End Module
