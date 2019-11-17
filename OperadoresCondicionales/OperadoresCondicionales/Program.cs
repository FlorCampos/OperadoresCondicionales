using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "7 == 3 + 4 --> " + (7 == 3 + 4));

            Console.WriteLine(
                "7 != 3 + 4 --> " + (7 != 3 + 4));

            int nota = 18;

            //if(nota >= 0 && nota <= 20)
            //{
            //    Console.WriteLine("Nota Correcta");
            //}
            //else
            //{
            //    Console.WriteLine("Nota Incorrecta");
            //}

            string rpta = (nota >= 0 && nota <= 20) // & : amperson
                ? "Nota Correcta" // reemplaz al if
                : "Nota Incorrecta"; //reemplaza al else

            Console.WriteLine(rpta);

            


            Console.ReadKey();
        }
    }
}
