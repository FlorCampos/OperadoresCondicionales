using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._PrintDay
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
                    Console.WriteLine("\n\tes domingo");
                    break;

                case 1:
                    Console.WriteLine("\n\tes lunes");
                    break;

                case 3:
                    Console.WriteLine("\n\tes martes");
                    break;

                case 4:
                    Console.WriteLine("\n\tes miércoles");
                    break;

                case 5:
                    Console.WriteLine("\n\tes jueves");
                    break;

                case 6:
                    Console.WriteLine("\n\tes viernes");
                    break;

                case 7:
                    Console.WriteLine("\n\tes sábado");
                    break;

                default:
                    Console.WriteLine("\n\tIngreso incorrecto");
                    break;
            }

            Console.ReadKey();

        }
    }
}
