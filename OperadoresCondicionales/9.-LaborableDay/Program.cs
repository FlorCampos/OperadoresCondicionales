using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._LaborableDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese número de la semana : ");
            int d = Convert.ToInt32(Console.ReadLine());

            switch (d)
            {
                case 0:
                case 6:
                    Console.WriteLine("\n\tNo es laborable");
                    break;

                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("\n\tEs laborable");
                    break;

                default:
                    Console.WriteLine("\n\tIngreso incorrecto");
                    break;
            }

            Console.ReadKey();
        }
    }
}
