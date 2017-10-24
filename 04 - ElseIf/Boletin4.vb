Option Strict On
Module Module1

    Sub Main()
        Dim ejercicio As Integer
        Dim continuar As Char
        Do

            Console.WriteLine("Escoja un ejercicio del 4 al 15")
            ejercicio = Convert.ToInt32(Console.ReadLine())

            Select Case ejercicio
                Case 4
                    Dim a, b, c, d, menor As Integer
                    a = 9
                    b = 5
                    c = 2
                    d = 10

                    If a < b Then
                        If a < c Then
                            If a < d Then
                                menor = a
                            Else
                                menor = d
                            End If
                        ElseIf c < d Then
                            menor = c
                        Else
                            menor = d
                        End If
                    ElseIf b < c Then
                        If b < d Then
                            menor = b
                        Else
                            menor = d
                        End If
                    ElseIf c < d Then
                        menor = c
                    Else
                        menor = d
                    End If
                    Console.WriteLine("El menor es: " & menor)
                    Console.ReadLine()
                Case 5
                    Console.WriteLine("Ha escogido el ej 5: ")
                    Dim nota As Double
                    Dim fallo As Boolean = False
                    Do
                        fallo = False
                        Try

                            Console.WriteLine("Intro la nota: ")
                            nota = Convert.ToByte(Console.ReadLine())

                            If nota < 0 Or nota > 10 Then
                                Console.WriteLine("ERror en nota")
                            ElseIf nota < 5 Then
                                Console.WriteLine("Suspenso")
                            ElseIf nota <= 6.5 Then
                                Console.WriteLine("Aprobado")
                            ElseIf nota <= 8.5 Then
                                Console.WriteLine("Notable")
                            Else
                                Console.WriteLine("Sobresaliente")
                            End If
                        Catch ex As FormatException
                            Console.WriteLine("Caracteres no válidos")
                            fallo = True
                        Catch ex As OverflowException
                            Console.WriteLine("Número demasiado alto")
                            fallo = True
                        Catch ex As Exception
                            Console.WriteLine("No se lo que pasó pero algo va mal!")
                            fallo = True
                        End Try

                    Loop While fallo = True

                Case 6
                    Console.WriteLine("Ha escogido el ej 6: ")
                    Dim numero As Integer = 15

                    If numero Mod 4 = 0 Then
                        numero += 25
                    ElseIf numero Mod 5 = 0 Then
                        numero += 50
                    Else
                        numero += 100
                    End If


                Case 7
                    Console.WriteLine("Ha escogido el ej 7: ")
                    Dim temperatura As Integer = 10

                    If temperatura < 0 Then
                        Console.WriteLine("Hielo")
                    ElseIf temperatura < 100 Then
                        Console.WriteLine("Agua")
                    Else
                        Console.WriteLine("Vapor")
                    End If



                Case 8
                    Console.WriteLine("Ha escogido el ej 8: ")
                    Dim opcion As String
                    Dim n1, n2 As Integer

                    Console.WriteLine("Escoja la opción deseada:")
                    Console.WriteLine("1. Sumar")
                    Console.WriteLine("2. Restar")
                    Console.WriteLine("3. Multiplicar")
                    Console.WriteLine("4. Dividir")
                    Console.WriteLine("5. Raiz de la suma")
                    opcion = Console.ReadLine()


                    If opcion = "1" Then
                        Console.WriteLine("Intro num1:")
                        n1 = Convert.ToInt32(Console.ReadLine())
                        Console.WriteLine("Intro num2: ")
                        n2 = Convert.ToInt32(Console.ReadLine())
                        Dim suma As Integer = n1 + n2
                        Console.WriteLine("Suma: " & suma)
                    ElseIf opcion = "2" Then
                        Console.WriteLine("Intro num1:")
                        n1 = Convert.ToInt32(Console.ReadLine())
                        Console.WriteLine("Intro num2: ")
                        n2 = Convert.ToInt32(Console.ReadLine())
                        Dim resta As Integer = n1 - n2
                        Console.WriteLine("Resta: " & resta)
                    ElseIf opcion = "3" Then
                        Console.WriteLine("Intro num1:")
                        n1 = Convert.ToInt32(Console.ReadLine())
                        Console.WriteLine("Intro num2: ")
                        n2 = Convert.ToInt32(Console.ReadLine())
                        Dim multipl As Integer = n1 * n2
                        Console.WriteLine("Multiplicación : " & multipl)
                    ElseIf opcion = "4" Then
                        Console.WriteLine("Intro num1:")
                        n1 = Convert.ToInt32(Console.ReadLine())
                        Console.WriteLine("Intro num2: ")
                        n2 = Convert.ToInt32(Console.ReadLine())
                        'Si n2 = 0 no se puede calcular la division
                        Dim division As Double = n1 / n2
                        Console.WriteLine("Division: " & division)
                    ElseIf opcion = "5" Then
                        Console.WriteLine("Intro num1:")
                        n1 = Convert.ToInt32(Console.ReadLine())
                        Console.WriteLine("Intro num2: ")
                        n2 = Convert.ToInt32(Console.ReadLine())
                        Dim suma As Integer = n1 + n2
                        Console.WriteLine("Raiz de la suma: " & Math.Sqrt(suma))
                    Else
                        Console.WriteLine("La opción escogida no es correcta")
                    End If


                Case 9
                    Console.WriteLine(" Ha escogido el ej 9: ")
                    Dim litros, pago As Integer
                    Console.WriteLine("Introduzca litros consumidos:")
                    litros = Convert.ToInt32(Console.ReadLine())

                    If litros <= 50 Then
                        pago = 0
                    ElseIf litros < 200 Then
                        pago = (litros - 50) * 10
                    Else
                        pago = (litros - 200) * 20 + 150 * 10
                    End If

                    If pago < 500 Then
                        pago = 500
                    End If

                    Console.WriteLine("Debe pagar " & pago & " euros.")

                Case 10
                    Dim horas, tasa, horasExtra As Integer
                    Dim salarioBruto, salarioNeto As Double

                    horas = 40
                    tasa = 10

                    If horas <= 38 Then
                        salarioBruto = horas * tasa
                    Else
                        horasExtra = horas - 38
                        salarioBruto = 38 * tasa + horasExtra * (tasa * 1.5)
                    End If

                    If salarioBruto > 300 Then
                        ' salarioNeto = salarioBruto - salarioBruto * 0.1
                        salarioNeto = salarioBruto * 0.9
                    Else
                        salarioNeto = salarioBruto
                    End If

                Case 11
                    Dim indicador As Integer = 1

                    Select Case indicador

                        Case 1
                            Console.WriteLine("Calor")
                        Case 2
                            Console.WriteLine("Templado")
                        Case 3
                            Console.WriteLine("Frío")
                        Case 4
                            Console.WriteLine("Fuera de rango")

                    End Select
                Case 12
                    Dim color As Char = "r"c

                    Select Case color
                        Case "r"c, "R"c
                            Console.WriteLine("Rojo")
                        Case "v"c, "V"c
                            Console.WriteLine("Verde")
                        Case "a"c, "A"c
                            Console.WriteLine("Azul")
                        Case Else
                            Console.WriteLine("Negro")
                    End Select
                Case 13
                    Console.WriteLine("Ejercicio 13: Resolución ecuación de segundo grado:")
                    Dim a, b, c As Integer
                    Dim sol1, sol2 As Double
                    Dim solucion As Boolean = False

                    a = 4
                    b = 2
                    c = 1

                    If a = 0 Then

                        sol1 = -c / b
                        sol2 = sol1
                        solucion = True
                    ElseIf b = 0 Then
                        Dim radicando As Double = -c / a
                        If radicando > 0 Then
                            sol1 = Math.Sqrt(radicando)
                            sol2 = -sol1
                            solucion = True

                        End If

                    ElseIf c = 0 Then
                        sol1 = 0
                        sol2 = -b / a
                        solucion = True
                    Else
                        Dim radicando As Double = b * b - 4 * a * c
                        If radicando > 0 Then
                            sol1 = (-b + Math.Sqrt(radicando)) / (2 * a)
                            sol2 = (-b - Math.Sqrt(radicando)) / (2 * a)
                            solucion = True

                        End If

                    End If

                    If solucion Then
                        Console.WriteLine("Solucion 1: " & sol1)
                        Console.WriteLine("Solucion 2: " & sol2)
                    Else
                        Console.WriteLine("No existe solucion real")
                    End If

                    Console.ReadLine()

                Case 14

                    Console.WriteLine("Ej 14: Comprobar año bisiesto")
                    Dim anho As Integer = 16
                    Dim bisiesto As Boolean = False

                    If anho Mod 4 = 0 Then
                        If anho Mod 100 = 0 Then
                            If anho Mod 400 = 0 Then 'Mútipl de 4,100,400
                                bisiesto = True
                            Else 'Multiplo de 4 de 100 y no de 400
                                bisiesto = False
                            End If
                        Else 'Mútiplo de 4 y no de 100
                            bisiesto = True
                        End If
                    Else
                        bisiesto = False
                    End If

                    If bisiesto Then
                        Console.WriteLine("Bisiesto")
                    Else
                        Console.WriteLine("No bisiesto")
                    End If


                Case 15

                    Console.WriteLine("Ejercicio 15: Ordenar 3 números de menor a mayor.")
                    Dim a, b, c, menor, mayor, medio As Integer
                    a = 4
                    b = 3
                    c = 5

                    If a < b And a < c Then
                        If b < c Then
                            menor = a
                            mayor = c
                            medio = b
                        Else
                            menor = a
                            medio = c
                            mayor = b
                        End If
                    ElseIf b < a And b < c Then
                        If a < c Then
                            menor = b
                            mayor = c
                            medio = a
                        Else
                            menor = b
                            medio = c
                            mayor = a
                        End If
                    Else
                        If b < a Then
                            menor = c
                            medio = b
                            mayor = a
                        Else
                            menor = c
                            medio = a
                            mayor = b
                        End If
                    End If

                    Console.WriteLine(menor & " " & medio & " " & mayor)
                    Console.ReadLine()

                Case 16
                    Console.WriteLine("Ejer 16: Descuento precio 3 artículos:")
                    Dim precio1, precio2, precio3, precioFinal As Double
                    precio1 = 10
                    precio2 = 5
                    precio3 = 50

                    precioFinal = precio1 + precio2 + precio3

                    If precioFinal < 500 Then
                        precioFinal = precioFinal ' No hay descuento
                    ElseIf precioFinal < 1000 Then
                        precioFinal = precioFinal - precioFinal * 0.03

                    ElseIf precioFinal < 2000 Then
                        precioFinal = precioFinal - precioFinal * 0.05
                    ElseIf precioFinal < 3000 Then
                        precioFinal = precioFinal - precioFinal * 0.07
                    Else
                        precioFinal = precioFinal - precioFinal * 0.1

                    End If


                Case Else
                    Console.WriteLine("Erroooooooor")
            End Select
            Console.WriteLine("Desea seguir jugando? s/n")
            continuar = Convert.ToChar(Console.ReadLine())
            Console.Clear()
        Loop While continuar = "s"c Or continuar = "S"c
        Console.ReadLine()

    End Sub

End Module
