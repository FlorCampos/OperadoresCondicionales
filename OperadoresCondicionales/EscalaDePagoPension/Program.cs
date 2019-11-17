using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._EscalaDePagoPension
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("\n\tIngrese la cantida de cursos a llevar : ");
            int cantCursos = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\tIngrese la categoría : ");
            string categoria = Console.ReadLine();

            double cuotaFija = 350;
            double cuotaVariable = 0;

            switch (categoria.ToUpper()) //lo convierte a mayúscula
            {
                case "A":
                    cuotaVariable = (cantCursos >= 1 && cantCursos <= 5)
                    ? 400 : (cantCursos >= 6 && cantCursos <= 8)
                    ? 600 : 900;
                    break;
                case "B":
                    cuotaVariable = (cantCursos >= 1 && cantCursos <= 3)
                    ? 400 : (cantCursos >= 4 && cantCursos <= 7)
                    ? 600 : 900;
                    break;
                case "C":
                    cuotaVariable = (cantCursos >= 1 && cantCursos <= 3)
                    ? 400 : (cantCursos >= 4 && cantCursos <= 7)
                    ? 600 : 900;
                    break;
                case "D":
                    cuotaVariable = (cantCursos >= 1 && cantCursos <= 4)
                     ? 400 : (cantCursos >= 5 && cantCursos <= 8)
                    ? 600 : 900;
                    break;
                default:
                    Console.WriteLine("\n\tCategoría Errónea");
                    break;
            }

            double importeCuota = cuotaFija + cuotaVariable;

            Console.WriteLine("\n\tEl monto de la boleta es : " + importeCuota);
            Console.ReadKey();
        }

    }
          
    
}
