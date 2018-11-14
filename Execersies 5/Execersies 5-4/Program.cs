using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execersies_5_4
{
    class Program
    {

        public string oneToHundred(int n)
        {
            String str = " ";
            while (n !=0)
            {
                if (n == 1)
                {
                    str = str + "one";
                    n = 0;
                }else if (n == 2)
                {
                    str = str + "two";
                    n = 0;
                }
                else if (n == 3)
                {
                    str = str + "three";
                    n = 0;
                }
                else if (n == 4)
                {
                    str = str + "four";
                    n = 0;
                }
                else if (n == 5)
                {
                    str = str + "five";
                    n = 0;
                }
                else if (n == 6)
                {
                    str = str + "six";
                    n = 0;
                }
                else if (n == 7)
                {
                    str = str + "seven";
                    n = 0;
                }
                else if (n == 8)
                {
                    str = str + "eight";
                    n = 0;
                }
                else if (n == 9)
                {
                    str = str + "nine";
                    n = 0;
                }
                else if (n == 10)
                {
                    str = str + "ten";
                    n = 0;
                }
                else if (n == 11)
                {
                    str = str + "eleven";
                    n = 0;
                }
                else if (n == 12)
                {
                    str = str + "twelve";
                    n = 0;
                }
                else if (n == 13)
                {
                    str = str + "thriteen";
                    n = 0;
                }
                else if (n == 14)
                {
                    str = str + "fourteen";
                    n = 0;
                }
                else if (n == 15)
                {
                    str = str + "fifteen";
                    n = 0;
                }
                else if (n == 16)
                {
                    str = str + "sixteen";
                    n = 0;
                }
                else if (n == 17)
                {
                    str = str + "seventeen";
                    n = 0;
                }
                else if (n == 18)
                {
                    str = str + "eighteen";
                    n = 0;
                }
                else if (n == 19)
                {
                    str = str + "nineteen";
                    n = 0;
                }
                else if (n == 20)
                {
                    str = str + "twenty";
                    n = 0;
                }
               
            }
            string result = str;
            //Console.WriteLine("The Input  number is " + result);
            return result;
        }


        public string convertNumber(int n)
        {
            string str2 = "";
            while (n != 0)
            {
                if (n >= 20 && n<30)
                {
                    
                    str2 = "twenty";
                    n = n - 20;
                    str2 = str2 + oneToHundred(n);
                    n = 0;
                }
                else if (n >= 30 && n < 40)
                {
                    str2 = "thirty";
                    n = n - 30;
                    str2 = str2 + oneToHundred(n);
                    n = 0;
                }
                else if (n >= 40 && n < 50)
                {
                    str2 =  "fourty";
                    n = n - 40;
                    str2 = str2 + oneToHundred(n);
                    n = 0;
                }
                else if (n >= 50 && n < 60)
                {
                    str2 =  "fifty";
                    n = n - 50;
                    str2 = str2 + oneToHundred(n);
                    n = 0;
                }
                else if (n >= 60 && n < 70)
                {
                    str2 =  "sixty";
                    n = n - 60;
                    str2 = str2 + oneToHundred(n);
                    n = 0;
                }
                else if (n >= 70 && n < 80)
                {
                    str2 =  "Senventy";
                    n = n - 70;
                    str2 = str2 + oneToHundred(n);
                    n = 0;
                }
                else if (n >= 80 && n < 90)
                {
                    str2 =  "eighty";
                    n = n - 80;
                    str2 = str2 + oneToHundred(n);
                    n = 0;
                }
                else if (n >= 90 && n < 100)
                {
                    str2 =  "ninety";
                    n = n - 90;
                    str2 = str2 + oneToHundred(n);
                    n = 0;
                }
                else if (n == 100)
                {
                    str2 = "Hundred";
                    n = 0;
                }               

            }
            string result2 = str2;           
            return str2;
        }


        static void Main(string[] args)
        {
            String str;
            Program p1 = new Program();
            Console.Write(" Please Enter Number ");
            int number = int.Parse(Console.ReadLine());
            str = p1.convertNumber(number);
            Console.Write("  " + str);
    
       
            Console.ReadKey();
        }
    }
}
