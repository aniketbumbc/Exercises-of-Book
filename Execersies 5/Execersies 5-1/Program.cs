using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execersies_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers A ,B and C");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if(a>b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine(a + ">" + b + ">" + c);
                }
                else
                {
                    Console.WriteLine(a + ">" + c + ">" + b);
                }
            }
            else if(b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine(b + ">" + a + ">" + c);
                }
                else
                {
                    Console.WriteLine(b + ">" + c + ">" + a);
                }                
            }else if(c>a && c > b)
            {
                if (a > b)
                {
                    Console.WriteLine(c + ">" + a + ">" + b);
                }
                else
                {
                    Console.WriteLine(c + ">" + b + ">" + a);
                }
            }
            Console.ReadKey();
        }
    }
}
