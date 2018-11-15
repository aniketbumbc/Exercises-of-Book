using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter into While Loop");
            int counter = 0;
            while (counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.WriteLine("Enter into Sum of while loop");
            int sum = 1;
            int n = 1;
            int num = int.Parse(Console.ReadLine());
            while (n < num) {
                sum = sum + n;
                n++;
                Console.WriteLine("The Value of sum is " + sum);
            }

            Console.ReadKey();
        }
    }
}
