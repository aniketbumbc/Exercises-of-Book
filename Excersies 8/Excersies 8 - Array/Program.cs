using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_8___Array
{
    class Program
    {
        static void largeNumber(params int[] numbers)
        {
            int bigNumber = 1;
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length-1; i++)
            {
             if(numbers[i] > numbers[i + 1])
                {
                    bigNumber = numbers[i];
                }
                else
                {
                    bigNumber = numbers[i + 1];
                }
            }
            Console.Write(" The biggest number in array :- " +bigNumber);
        }
        static void Main(string[] args)
        {
            int[] num = { 1, 4, 5, 3, 10,456,34,23,676 };
            largeNumber(num);
            Console.ReadKey();
        }
    }
}
