using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfelseLeapyear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter year : ");
            year = Convert.ToInt32(Console.ReadLine());
                if (year % 4 == 0)
            {
                Console.WriteLine("This is a leap year");
            }
            else
            {
                Console.WriteLine("This is not a leap year.");
            }
            Console.ReadKey();
        }
    }
}
