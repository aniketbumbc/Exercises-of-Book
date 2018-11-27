using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execersies_7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int N ,K;
            int[] numbers;
            int sum = 0;

            Console.WriteLine("Enter number K < N ");
            Console.Write("Enter value of K ");
            K = Int32.Parse(Console.ReadLine());
            Console.Write("Enter value of N ");
            N = int.Parse(Console.ReadLine());
            numbers = new int[N];
     
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers, (a, b) => b.CompareTo(a));
            

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Sort array");
                Console.WriteLine(numbers[i]);
            }
            for(int i = 0; i < K; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("\nBiggest sum is {0}", sum);

            Console.ReadLine();
        }
    }
}
