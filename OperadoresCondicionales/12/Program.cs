using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._EnoughMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\tIngrese cantidad de caramelos de tipo Ambrosoli : ");
            int cantAmbrosoli = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\tIngrese cantidad de caramelos de tipo Tic Tac : ");
            int cantTicTac = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\tIngrese cantidad de caramelos de tipo Donofrio : ");
            int cantDonofrio = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\tMonto de propina : ");
            double montoPropina = Convert.ToDouble(Console.ReadLine());

            double montoCompra = cantAmbrosoli * 0.75 + cantTicTac * 1.15 + cantDonofrio * 0.65;
            string mensaje = (montoPropina < montoCompra)
                ? "\n\tAnálisis : Dinero insuficiente"
                : "\n\tAnálisis : El dinero es suficiente";




            Console.WriteLine("\n\tMonto de la compra : S/." + montoCompra);
            Console.WriteLine(mensaje);
            Console.ReadKey();
        }
    }
}
