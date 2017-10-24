using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication53
{
    class Program
    {
        enum diasSemana { LUNES, MARTES, MIERCOLES };
        static void Main(string[] args)
        {
            diasSemana x = diasSemana.LUNES;
         
        float nota;
            char continuar;
            // Solicitar nota por teclado
            
            do
            {
                Console.WriteLine("Introduzca una nota: ");
                nota = float.Parse(Console.ReadLine());

                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("Error en la nota.");
                }
                else if (nota > 0 && nota < 5)
                {
                    Console.WriteLine("Suspenso.");
                }
                else if (nota < 6.5)
                {
                    Console.WriteLine("Aprobado.");
                }
                else if (nota < 8.5)
                    Console.WriteLine("Notable.");
                else
                {
                    Console.WriteLine("Sobresaliente.");
                }
                Console.WriteLine("Desea seguir poniendo notas s/n ?");
                continuar = Convert.ToChar(Console.ReadLine());
            }
            while (continuar == Convert.ToChar("s"));

            //Ejercicio 11
            int indicador = 1;

            switch (indicador)
            {
                case 1:
                    Console.WriteLine("CALOR");
                    break;
                case 2:
                    Console.WriteLine("TEMPLADO");
                    break;
                case 3:
                    Console.WriteLine("FRIO");
                    break;
                default:
                    Console.WriteLine("Fuera de rango");
                    break;
            }
            Console.ReadLine();     
            

        }
    }
}
