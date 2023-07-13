using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_aasign4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num =  Convert.ToInt32(Console.ReadLine());

            if(num > 0)
            {
                Console.WriteLine("The number is Positive");
            }
            else if(num < 0)
            {
                Console.WriteLine("The number is Negative");
            }
            else
            {
                Console.WriteLine("The number is Zero");
            }

            string evenORodd = (num % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine("The number is " + evenORodd + ".");

            Console.ReadKey();
               
        }
    }
}
