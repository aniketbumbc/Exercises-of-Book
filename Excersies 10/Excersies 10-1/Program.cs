using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_10_1
{
    class Program
    {
        static int numberOfLoops;
        static int numberOfIteration;
        static int[] loops;
        static void Main(string[] args)
        {            
            Console.Write(" N = ");
            numberOfLoops = int.Parse(Console.ReadLine());
            Console.Write(" K = ");
            numberOfIteration = int.Parse(Console.ReadLine());
            loops = new int[numberOfLoops];
            NestedLoops(0);
            Console.ReadKey();
        }
        static void NestedLoops( int currentLoops)
        {
            if(currentLoops == numberOfLoops)
            {
                printLoops();
                return;
            }
            for(int c = 1; c <= numberOfIteration; c++)
            {
                loops[currentLoops] = c;
                NestedLoops(currentLoops + 1);
            }
        }
        static void printLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0}", loops[i]);
            }
            Console.WriteLine();
        }
    }
}
