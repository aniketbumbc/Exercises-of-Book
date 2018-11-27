using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execersies_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Element array 1 ");
            int n = int.Parse(Console.ReadLine());           
            int[] numbers1 = new int[n];
            for(int i = 0; i < numbers1.Length; i++)
            {
                numbers1[i] = int.Parse(Console.ReadLine());             
            }

            Console.Write("Please Enter Element array 2 ");
            int m = int.Parse(Console.ReadLine());
            int[] numbers2 = new int[m];
            for(int i=0; i<numbers2.Length; i++)
            {
                numbers2[i] = int.Parse(Console.ReadLine());

            }
            //sort array 
            Array.Sort(numbers1);
            Array.Sort(numbers2);
            Console.WriteLine("Check Length of aaray");
            if (numbers1.Length == numbers2.Length)
            {
               
                Console.WriteLine("Length is equal of array");

                Console.WriteLine("Check Each Element of array");

                for (int i = 0; i < numbers1.Length; i++)
                {
                    for (int j = 0; j<=i; j++)
                    {
                        int a = numbers1[i];
                        int b = numbers2[j];

                        if (a == b)
                        {
                            Console.WriteLine("Element Match " + numbers2[j]);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Length is not equal to array");
            }
            Console.Read();
        }
    }
}
