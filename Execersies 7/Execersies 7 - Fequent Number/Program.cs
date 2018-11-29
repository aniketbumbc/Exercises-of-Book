using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execersies_7___Fequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate count");
            int count = 0;
            int[] numbers = { 1,23,55,55,0,0,1,55};
            int tempCount = 1;
            int foundNumber = 0;

            Array.Sort(numbers);
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;                   
                }             
                else
                {
                    count = 1;
                }
                if(count > tempCount)
                {
                    //tempCount = count;
                    foundNumber = numbers[i];

                }
            }

            Console.WriteLine("The count is  " + count + " times and  Number is " + foundNumber);
            Console.ReadLine();
        }
    }
}
