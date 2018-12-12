using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_10_2
{
    class Program
    {
        static void nestedLoop(int[] number, int index)
        {
            if (index >= number.Length)
            {
                foreach (int numbers in number)
                    Console.Write("{0}", numbers);
                Console.WriteLine();
            }
            else
            {
                for(int i = 1; i <= number.Length; i++)
                {
                    number[index] = i;
                    nestedLoop(number, index + 1);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Nested Loop ");

            int n;
            Console.Write("Enter Value of N : -");
            n= int.Parse(Console.ReadLine());
            int[] number = new int[n];
            nestedLoop(number, 0);
            Console.ReadKey();
        }
    }
}
