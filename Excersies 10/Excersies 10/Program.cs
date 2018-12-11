using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_10
{
    class Program
    {
        static decimal Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Recursion Problem");
            Console.WriteLine(Factorial(4));
            Console.ReadKey();
        }
    }
}
