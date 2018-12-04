using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_8_3
{
    class Program
    {
        static int findOccurence(int [] array)
        {
            int count = 0;           
            Array.Sort(array);
            for(int i =0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    count++;
                }                   
               
            }

            return count;
        }
        
        static void Main(string[] args)
        {
            int[] n = { 1, 3, 4, 4, 3,4,4,9 };
           Console.WriteLine( " The count value is " + findOccurence(n));
            Console.ReadKey();
        }
    }
}
