using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_11_3
{
    class Program
    {
    
        public static void  CalulateSum(string numbers)
        {
            int result = 0;
            string[] newNumber = numbers.Split(' ');
            for(int i = 0; i <= newNumber.Length-1; i++)
            {
                result += Convert.ToInt32(newNumber[i]);
            }

            Console.WriteLine("The Final Sum " + result);

        }

        static void Main(string[] args)
        {
            
            Console.WriteLine(" Enter Value Of Integer ");
            string numbers = (Console.ReadLine());
            CalulateSum(numbers);
            Console.ReadKey();
        }
    }
}
