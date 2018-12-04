using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_8_1
{
    class Program
    {
        static void printData(string str, int number)
            {
            Console.WriteLine(" The value of string is " + str + " Number is " + number);
            }
        static void printData(string str)
        {
            Console.WriteLine(" This is only string " + str);
        }

        static void printTringle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(" Method Overloading ");

            printData("Hello", 007);
            printData(" Hello No 007 ");

            Console.Write(" See this Tringle and Enter N :- ");
            
            int n = int.Parse(Console.ReadLine());
            printTringle(n);

            Console.ReadKey();
        }
    }
}
