using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine( "A " +a);
            }else if (b > c)
            {
                Console.WriteLine("B " +b);
            }
            else if(c > d)
            {
                Console.WriteLine("C " +c);
            }else if(d > e)
            {
                Console.WriteLine("D " + d);
            }
            else
            {
                Console.WriteLine("E " + e);
            }
            Console.ReadKey();
        }
    }
}
