using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._OperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            //un operador es más eficiente que una estructura de control
            Console.Write("\n\tNota [0,20]: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string msg = (n >= 0) && (n <= 20) //la condición del if
                ? "\n\tNota Correcta"
                : "\n\tNota Incorrecta";
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
