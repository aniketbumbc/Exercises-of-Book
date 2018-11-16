using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Excersies_6_Fact
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FactWorld");
            Console.Write("Enter Number ");
            int n = int.Parse(Console.ReadLine());
            BigInteger Fact = 1;
            Fact = Fact * n;
            while (n > 1)
            {                
                Fact = Fact*(n - 1);
                n--;               
            }
            Console.WriteLine("The out oput is " + Fact);
            Console.ReadKey();
        }
    }
}
