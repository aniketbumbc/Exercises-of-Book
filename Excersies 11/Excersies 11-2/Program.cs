using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_11_2
{
    class Program
    {
       

        public static void randomNumber(int number)
        {
            Random rand = new Random();
            int randomNumber = 1;
            for ( int i =1; i <= 10; i++)
            {
                randomNumber = rand.Next(100) + number;
                Console.WriteLine(randomNumber);
            }   
                        
         }


        static void Main(string[] args)
        {
            Console.Write(" Enter Random Number N :- ");
            int number = int.Parse(Console.ReadLine());
            randomNumber(number);

            var machineName = Environment.MachineName;
          

            Console.ReadKey();
        }
    }
}
