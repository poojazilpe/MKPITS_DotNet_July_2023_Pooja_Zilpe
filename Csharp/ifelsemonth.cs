using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelsemonth
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit;
            Console.WriteLine("Enter digit(1 to 12) :");
            digit = Convert.ToInt32(Console.ReadLine());

            if (digit == 1)
            {
                Console.WriteLine("January");
            }
            else if (digit == 2)
            {
                Console.WriteLine("February");
            }
            else if (digit == 3)
            {
                Console.WriteLine("March");
            }
            else if (digit == 4)
            {
                Console.WriteLine("April");
            }
            else if (digit == 5)
            {
                Console.WriteLine("May");
            }
            else if (digit == 6)
            {
                Console.WriteLine("June");
            }
            else if (digit == 7)
            {
                Console.WriteLine("July");
            }
            else if (digit == 8)
            {
                Console.WriteLine("August");
            }
            else if (digit == 9)
            {
                Console.WriteLine("september");
            }
            else if (digit == 10)
            {
                Console.WriteLine("Octber");
            }
            else if (digit == 11)
            {
                Console.WriteLine("November");
            }
            else if (digit == 12)
            {
                Console.WriteLine("December");
            }
            else
            {
                Console.WriteLine("Invalid month");
            }
            Console.ReadKey();
        }
    }
}
