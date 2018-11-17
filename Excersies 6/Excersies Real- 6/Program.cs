using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_Real__6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fact1 = 1;
            for (int i = 1; i <= 10; i++)
            {           
                Fact1 = Fact1 * i;            
            }
            Console.WriteLine(Fact1);
            int Fact2 = 1;
            for (int i = 1; i <= 5; i++)
            {
                Fact2 = Fact2 * i;
            }
            Console.WriteLine(Fact2);

            int result = Fact1 / Fact2;
            Console.WriteLine("Final Result " +result);
            Console.ReadKey();
        }
    }
}
