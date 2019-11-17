using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n" + "  Ingrese valor : ");
            double x = Convert.ToDouble(Console.ReadLine());

            // test if "x" is different than zero

            if (x != 0)
            {
                Console.WriteLine("\n" + "  "+ x + " es diferente de CERO");
            }

            // test if "x" is positive or negative number

            if (x >= 0) // For this case, consider a Zero as a positive number
            {
                Console.WriteLine("\n" + "  " + x + " es POSITIVO");
            }

            else
            {
                Console.WriteLine("\n" + "  " + x + " es NEGATIVO");
            }

            // Test if "x" is greater than zero , less than zero or Zero

            if (x >= 0) 
            {
                Console.WriteLine("\n" + "  " + x + " es mayor que cero");
            }

            else if(x < 0)
            {
                Console.WriteLine("\n" + "  " + x + " es menor que cero");
            }

            else
            {
                Console.WriteLine("\n" + "  " + x + " cero");
            }
            Console.ReadKey();
        }
    }
}
