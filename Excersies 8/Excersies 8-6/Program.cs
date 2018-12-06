using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_8_6
{
    class Program
    {
        static void factorial(int n)
        {           
            int fact = 1;
            do
            {
                fact = fact * n;                
                n--;
            } while (n >= 1);

            Console.WriteLine(" The Factorial is " + fact);
        }
        static void Main(string[] args)
        {
            Console.Write("Please Enter Value of N :-  ");
            int n = int.Parse(Console.ReadLine());
            factorial(n);
            Console.ReadKey();
        }
    }
}
