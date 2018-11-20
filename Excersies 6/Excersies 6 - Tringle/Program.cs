using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_6___Tringle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Number");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                for(int j = i; j <= i+n-1; j++)
                {
                    Console.Write(j + " ");
                   
                }
                Console.WriteLine();
            }

            Console.WriteLine("Please Enter Array Size");
            int n2 = int.Parse(Console.ReadLine());
            int[] numbers = new int[n2];






            Console.ReadKey();
        }
    }
}
