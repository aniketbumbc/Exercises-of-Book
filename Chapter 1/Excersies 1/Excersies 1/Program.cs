using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string Fname, Lname;

            Console.WriteLine("Please Enter Name");
            Console.WriteLine("First Name ");
            Fname = Console.ReadLine();
            Console.WriteLine("Last Name ");
            Lname = Console.ReadLine();
            Console.WriteLine("The Full Name is " + Fname +" " +Lname);

            Console.WriteLine("The Current Date and Time ");
            DateTime currentDate = DateTime.Now;

            Console.WriteLine(currentDate);

            Console.ReadKey();
        }
    }
}
