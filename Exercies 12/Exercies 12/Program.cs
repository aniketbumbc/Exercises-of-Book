using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Excersies_12_Exception
    {
        class Program
        {
            public static void Calculation(int num1, int num2)
            {
                try
                {
                    int result = num1 / num2;

                    Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
                }
            catch (DivideByZeroException ex)
            {
                throw new ApplicationException(string.Format("Cannot divide by zero. Please try again."), ex);
            }
            catch (InvalidOperationException ex)
                {
                    throw new ApplicationException(string.Format("Invalid Data"), ex);
                }

            }

            static void Main(string[] args)
            {
                Console.WriteLine("Please enter two integer");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Calculation(num1, num2);

                Console.ReadKey();
            }
        }
    }

