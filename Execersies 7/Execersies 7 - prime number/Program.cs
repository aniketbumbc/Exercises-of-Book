using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execersies_7___prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Prime Number Program ");

            bool isPrime = true;
            Console.WriteLine(" Prime Number ");
            for(int i= 2; i <= 1000; i++)
            {
                for(int j = 2; j <= 100; j++)
                {
                    if(i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
            Console.ReadLine();
        }
    }
}
