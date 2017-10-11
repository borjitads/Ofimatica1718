using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerCSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Esto es un comentario
            * de muchas líneas
            * */
            //Tipos de variables
            byte n1 = 0;
            short n2 = 9;
            int n3 = n2 + n1;
            long n4;

            //Variables no están inicializadas
            Console.WriteLine(n1);

            //Conversiones explícitas
            n2 = (short)n3;
            n1 = Convert.ToByte(n2);

            //COn strings utilizar función Parse
            String telefono = "986755432";
            short numTelefono = Int16.Parse(telefono);
            int numTelefono2 = Int32.Parse(telefono);
            

            //Números decimales
            float n5 = 9.5f; //Convertir un numero decimal a float
            
            double n6 = 9.5;
            n5 = (float)n6;
            decimal n7;

            bool n8;
            char n9;
            String n10;


            //Calcular la media de 3 notas introducidas por teclado
            float nota1, nota2, nota3, media;
            Console.WriteLine("Nota 1:");
            nota1 = Single.Parse(Console.ReadLine());

            Console.WriteLine("Nota 2: ");
            nota2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Nota 3: ");
            nota3 = Single.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("La media es : " + media);

            if (media >= 5)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Suspenso");
            }
            Console.ReadLine();

            //Operadores C# diferentes a VB
            //Operador Mod es %
            int resto = 10 % 2; //Resto de 10 entre 2

            //Operador incremento: ++ y decremento --
            int x = 1;
            int y = ++x;
            int z = --x;

            //Operador de comparación ==

            if (z == 0)
            {

            }


        }
    }
}
