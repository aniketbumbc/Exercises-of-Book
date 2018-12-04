using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_8
{
    class Program
    {
        static int CalSum(params int [] elements)
        {
            int sum = 0;
            foreach(int element in elements)
            {
                sum += element;
            }
            return sum;
        }
        static void Main(string[] args)
        {
                      
            int sum = CalSum(2,4);
            Console.WriteLine(sum);

            int sum1 = CalSum(5,4,10,34,100);
            Console.WriteLine(sum1);

            int sum2 = CalSum(10, 4);
            Console.WriteLine(sum2);
            Console.ReadKey();
        }
    }
}
