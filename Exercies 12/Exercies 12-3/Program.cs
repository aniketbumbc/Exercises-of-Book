using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercies_12_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(" Random Numbers ");
                int random = new Random().Next(0, 3);
                Console.WriteLine("The Random Number is " + random);
                if(random == 0)
                {
                    throw new Exception("Random = 0");
                }if (random == 1)
                {
                    Console.WriteLine("Random = 1");
                    return;
                }
                Console.WriteLine("Random = 2");
            }
            finally
            {
                Console.WriteLine("Finally execute");
            }
            Console.ReadKey();
        }
    }
}
