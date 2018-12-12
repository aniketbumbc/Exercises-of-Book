using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersies_11
{
    class Program
    {
        public class Student
        {
            private int rollNumber;
            private string name;

            public Student()
            {
                this.rollNumber = 134;
                this.name = "Bunny";
                Console.WriteLine(this.rollNumber);
                Console.WriteLine(this.name);

            }

            public Student(int RollNumber, string Name)
            {
                this.rollNumber = RollNumber;
                this.name = Name;
                Console.WriteLine(" This is from Parameter Constructor ");
                Console.WriteLine(this.rollNumber +" " + this.name);
            }
        }

        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student(237,"Aniket");

            Console.ReadKey();
        }
    }
}
