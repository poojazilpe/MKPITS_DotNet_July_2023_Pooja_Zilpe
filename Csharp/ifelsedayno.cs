using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelsedayno
{
    class Program
    {
        static void Main(string[] args)
        { 
            int dayno;
            Console.WriteLine("Enter day no :");
            dayno = Convert.ToInt32(Console.ReadLine());

            if(dayno== 1)
            {
                Console.WriteLine("Monday");
            }
            else if (dayno == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (dayno == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (dayno == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (dayno == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (dayno == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (dayno == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Invalid Day");
            }
            Console.ReadKey();

        }
    }
}
