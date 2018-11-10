using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execersies_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check Number Even or Odd");
            int num1;
            Console.Write(" Please Enter Num1");
            num1 = int.Parse (Console.ReadLine());
           
            if(num1 == 0)
            {
                Console.WriteLine("Please Enter Correct Number");
            }
            else if (num1 % 2 == 0)                     
            {
                Console.WriteLine("Given Number " + num1 + " is  Even");
            }
            else
            {
                Console.WriteLine("Given Number " + num1 + " is Odd");
            }
            Console.ReadKey();
        }
    }
}
