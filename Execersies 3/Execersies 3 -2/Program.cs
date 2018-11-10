using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execersies_3__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Interger ");
            int num,a,b,c;
            //num = int.Parse(Console.ReadLine());
            //bool result = num % 5 == 0 && num % 7 == 0;             
            //    Console.WriteLine(result);

            num = int.Parse(Console.ReadLine());
            a = (num / 100);
            Console.WriteLine(a);
            b = (a % 10);       
            if (b == 7)
            {
                Console.WriteLine("The Number *********** " +b);
            }
            else
            {
                Console.WriteLine("Wrong number");
            } 
            Console.ReadKey();
        }
    }
}
