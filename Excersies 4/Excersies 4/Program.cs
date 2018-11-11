using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of Cirlce");
            int radius = int.Parse(Console.ReadLine());
            double areaOfCircle = 3.14 * (radius * radius);
            double perimeterOfCircle = (2 * 3.14 * radius);

            Console.WriteLine("Area of Cicle is " + areaOfCircle);
            Console.WriteLine("Perimeter of Cicle is " + perimeterOfCircle);


            Console.WriteLine("Enter 5 Digit Number");
            int num;            
            num = int.Parse(Console.ReadLine());
            int a = num % 10;        
            int b = (num / 10) % 10;    
            int c = (num / 100) % 10;       
            int d = (num / 1000) % 10;       
            int e = (num / 10000) % 10;       
            int Count = (num / 100000) % 10;
          
            if(Count == 0)
            {
                Console.WriteLine("Adddition of Number is " + (+a + b + c + d + e));
            }
            else
            {
                Console.WriteLine("Please enter correct number");
            }          
            Console.ReadKey();
        }
    }
}
