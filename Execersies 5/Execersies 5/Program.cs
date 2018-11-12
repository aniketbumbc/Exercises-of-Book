using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execersies_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers A and B");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The value of A and B is  A = " + a +" and B = " + b);

            if (a > b)
            {
                Console.WriteLine("The value of A is greater Than B  Swappingggg ");
                int c;
                c = a;
                a = b;
                b = c;
                Console.WriteLine("The Value of A and B is " + a + " " + b);
            }
            else
            {
                Console.WriteLine("The value of A and B is  A = " + a + " and B = " + b +" not wapping  ");
            }
            Console.ReadKey();
        }
    }
}
