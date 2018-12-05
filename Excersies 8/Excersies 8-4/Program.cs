using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_8_4
{
    class Program
    {
        
        static int getNumber(int n)
        {
            int lastDigit = 1;
            if (n != 0)
            {
                lastDigit = (n % 10);               
            }
            return lastDigit;
           
        }

        static void getText(int lastDigit)
        {
        
            switch (lastDigit)
            {
                case 0:
                Console.Write("Zero");
                    break;
                case 1:
                Console.Write("One");
                    break;
                case 2:
                    
                Console.Write("Two");
                    break;
                case 3:
                Console.Write("Three");
                    break;
                case 4:                    
                Console.Write("Four");
                    break;
                case 5:                    
                Console.Write("Five");
                    break;
                case 6:                  
                Console.Write("Six");
                    break;
                case 7:                  
                Console.Write("Seven");
                    break;
                case 8:                 
                Console.Write("Eight");
                    break;
                case 9:                    
                Console.Write("Nine");
                    break;
                default:
                    Console.Write("Please Enter Correct Number");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Please Enter Value of N :-  ");
            int n = int.Parse(Console.ReadLine());          
            int lastDigit = getNumber(n);
            getText(lastDigit);
            Console.ReadKey();
        }
    }
}
