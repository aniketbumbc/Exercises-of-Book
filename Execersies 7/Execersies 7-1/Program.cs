using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execersies_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter array from console  ");
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
           
            for(int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                
            }
            Array.Reverse(num);
            Console.WriteLine("Print Start Here");
            for(int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.Read();
        }
    }
}
