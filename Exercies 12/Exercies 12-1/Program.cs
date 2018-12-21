using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercies_12_1
{
    class Program
    {
        public static void calculationSum(int a, int b)
        {
            try
            {
                int result;
                result = a + b;
                Console.WriteLine("Hello Result is " + result);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Calculation of sum");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            calculationSum(a,b);
            Console.ReadKey();
        }
    }
}
