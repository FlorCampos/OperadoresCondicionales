using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._OperadorTernario02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask 3 values, after that print the lower, center and the greatest
            // Para usarlo en lugar del if

            Console.Write("\n\tValor 1 : ");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\tValor 2 : ");
            double v2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\tValor 3 : ");
            double v3 = Convert.ToDouble(Console.ReadLine());

            double min = (v1 <= v2 && v1 <= v3) // estas son las condiciones
                ? v1 : v2 <= v1 && v2 <= v3 // "?" se lee entonces -- primero es un NOR
                ? v2 : v3;

            double max = (v1 >= v2 && v1 >= v3) // estas son las condiciones
                ? v1 : v2 >= v1 && v2 >= v3 // "?" se lee entonces -- primero es un NOR
                ? v2 : v3;

            double cen = (v1 + v2 + v3) - (min + max);

            Console.WriteLine("\n\tEl menor es : " + min);
            Console.WriteLine("\n\tEl mayor es : " + max);
            Console.WriteLine("\n\tEl central es : " + cen);
            Console.ReadKey();
        }
    }
}
