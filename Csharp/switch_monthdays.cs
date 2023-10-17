//Write a program in C# Sharp to read any Month Number in integer and display the number of days for this month.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_monthdays
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;
            Console.WriteLine("Enter month no(1 to 12)");
            month = Convert.ToInt32(Console.ReadLine());
            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("This month have 31 days");
                    break;
                case 2:
                    Console.WriteLine("This month have 28 or 29 days");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("This month have 30 days");
                    break;

            }
            Console.ReadKey();
        }
    }
}
