using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execersies_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Socre With Bounce");
            int Score = int.Parse(Console.ReadLine());
            if(Score ==0 || Score > 9)
            {
                Console.Write("Please Enter Correct Score");
            }else if(Score ==1 || Score <= 3)
            {
                Console.Write("Score multilply by 10  = " +Score * 10);
            }
            else if (Score == 4 || Score <= 6)
            {
                Console.Write("Score multilply by 100  = " + Score * 100);
            }
            else if (Score == 7 || Score <= 9)
            {
                Console.Write("Score multilply by 10  = " + Score * 1000);
            }
            Console.ReadKey();
        }
    }
}
