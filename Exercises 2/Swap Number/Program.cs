using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 10;
            b = 5;

            Console.WriteLine("The value before swap is  a = " + a +" b = " + b);
            c = a;
            a = b;          
            b = c;
            Console.WriteLine("The value After swap is  a = " + a + " and b = " + b);
            Console.WriteLine("    o o.o o   ");
            Console.WriteLine("  o         o      ");
            Console.WriteLine("  o         o       ");
            Console.WriteLine("   o       o         ");
            Console.WriteLine("     o    o       ");
            Console.WriteLine("       o         ");
            Console.ReadKey();
        }
    }
}
