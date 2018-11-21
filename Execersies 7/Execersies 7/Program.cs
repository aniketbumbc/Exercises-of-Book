using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execersies_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Is here");
            int[] numbers = { 3, 5, 6, 7, 8, 2 };
            int numLength = numbers.Length;
            int[] revNumbers = new int[numLength];
            for(int i = 0; i < numLength; i++)
            {
                revNumbers[numLength - i - 1] = numbers[i];
            }

            for(int i = 0; i < numLength; i++)
            {
                Console.WriteLine(revNumbers[i]);
            }
            Console.Read();
        }
    }
}
