using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 12345;
            Console.WriteLine("Square Root of Number is ")
            double squareRoot = Math.Sqrt(number);
            Console.Write(+squareRoot);

            for(int i = 1; i <= 100; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("-" +i);
                }
            }

            int age;
            Console.WriteLine("Enter Your Current Age");
            age = int.Parse (Console.ReadLine());
            int nowAge = age + 10;
            Console.WriteLine("After 10 Year " + nowAge);
            Console.ReadKey();
        }
    }
}
