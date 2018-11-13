using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execersies_5_2_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Switch Case Here");
            Console.Write("Enter Variable type (0 -int, 1 -double, 2-string):");
            int caseEnter = int.Parse(Console.ReadLine());
            switch (caseEnter)
            {
                case 0:
                    {
                        Console.WriteLine("Enter int Variable");
                        int count = int.Parse(Console.ReadLine());
                        count++;
                        Console.WriteLine("Int variable case "+ count);
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Enter Double Variable");
                        double doublecount = double.Parse(Console.ReadLine());
                        doublecount++;
                        Console.WriteLine("Double variable " + doublecount);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter String Variable");
                        string stringcount = Console.ReadLine();
                        Console.WriteLine("String variable String" + stringcount + "*");
                        break;
                    }
                     default:Console.WriteLine("Please Enter Correct number");
                    break;
            }
            Console.ReadKey();
        }
    }
}
