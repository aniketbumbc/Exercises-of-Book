using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isMale = false;
            if (isMale)
            {
                Console.WriteLine("Male");
            }
            else
            {
                Console.WriteLine("Female");
            }

            string fname = "Hello";
            string lname = "world";

            object FullName = fname + " " + lname;

            string DFullName = (string)FullName;

            Console.WriteLine(DFullName);

            Console.ReadKey();
        }
    }
}
