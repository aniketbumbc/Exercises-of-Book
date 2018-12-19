using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercies_12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            string number = Console.ReadLine();
            int n = -1;
            bool invalidNumber = false;
            try
            {
                n = Convert.ToInt32(number);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid number!",e);
                invalidNumber = true;

            }
            finally
            {
                if (n > 0)
                {
                    if (invalidNumber)
                    {
                        Console.WriteLine("Invalid number!");
                    }
                    else
                    {
                        Console.WriteLine(Math.Sqrt(n));
                    }                       
                }
                Console.WriteLine("Good Bye");
            }
            Console.ReadKey();
        }
    }
}
