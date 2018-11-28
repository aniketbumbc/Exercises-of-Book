using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execersies_7___seletion_sort__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selection Sort");
            int[] numbers = { 3, 2, 4, 1 };
            int length = numbers.Length;

            for( int i= 0; i < length - 1; i++)
            {
                int min_temp = i;
                for(int j = i+1; j < length; j++)
                {
                    if (numbers[j] < numbers[min_temp])
                    {
                        min_temp = j;
                    }

                    int temp = numbers[min_temp];
                    numbers[min_temp] = numbers[i];
                    numbers[i] = temp;

                }               
            }
            for (int i = 0; i < length; ++i)
            {
                Console.WriteLine(numbers[i]);
            }

                
            Console.ReadLine();
        }
    }
}
