using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_Real_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Number N ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;          
            int num2 = 1;
            int num1 = 0;
            Console.WriteLine("0");
            Console.WriteLine("1");

            for (int i = 2; i <= n; i++){                 
                sum = num1 + num2;
                Console.WriteLine(sum);
                num1 = num2;
                num2 = sum;
               
            }
            Console.ReadKey();
        }
    }
}
