using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_8_5___Reverse__
{
    class Program
    {
        static int getReverse(int number)
        {
            int reverse = 0 ;
           while (number > 0)
            {
                int remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            return reverse;
           
        }
        static void Main(string[] args)
        {
            Console.Write("Please Enter Value of N :-  ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(getReverse(n));
            Console.ReadKey();
        }
    }
}
