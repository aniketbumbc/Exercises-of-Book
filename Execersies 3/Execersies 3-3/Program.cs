using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execersies_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine ("Please enter 4 Digit number");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("number is " + num);
            //Logic of reverse number
            int a = num % 10;
            int b = (num / 10) % 10;
            int c = (num / 100) % 10;
            int d = (num / 1000) % 10;
            Console.WriteLine(+a +" " + b + " " + c + " " + d);
            Console.WriteLine(a + b+ c + d);
            Console.ReadKey();
        }
    }
}
