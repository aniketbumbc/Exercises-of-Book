using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_11_1
{
    class Program
    {
        public static int leapYear(int year)
        {
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine(" Yes this is leap year ");
                return year;
            }
            else
            {
                Console.WriteLine(" No this is not a leap year ");
                return 000;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Leap Year Enter Year ");
            int year = int.Parse(Console.ReadLine());
            leapYear(year);
            Console.ReadKey();
        }
    }
}
