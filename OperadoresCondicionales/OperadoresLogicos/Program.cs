using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("true && true --> " + (true && true));
            Console.WriteLine("true && false --> " + (true && false));
            Console.WriteLine("false && true --> " + (false && true));
            Console.WriteLine("false && false --> " + (false && false));


            Console.WriteLine("true || true --> " + (true || true));
            Console.WriteLine("true || false --> " + (true || false));
            Console.WriteLine("false || true --> " + (false || true));
            Console.WriteLine("false || false --> " + (false || false));

            Console.WriteLine("!true --> " + !true);
            Console.WriteLine("!false --> " + !false);

            Console.ReadKey();
        }
    }
}
