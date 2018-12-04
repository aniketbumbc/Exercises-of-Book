using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_8_2
{
    class Program
    {
        static int getMax(int n1, int n2)
        {
            if (n1 > n2)
            {
                return n1;
            }
            else
                return n2;
        }

        static int getMax(int n1,int n2,int n3)
        {
            if (n1 > n2 && n1 > n3)
            {
                return n1;
            } else if (n2 > n1 && n2 > n3)
            {
                return n2;
            } else
                return n3;
        }



        static void Main(string[] args)
        {
             Console.WriteLine(getMax(34, 50));
            Console.WriteLine(getMax(10, 30, 10));
            Console.ReadKey();
        }
    }
}
