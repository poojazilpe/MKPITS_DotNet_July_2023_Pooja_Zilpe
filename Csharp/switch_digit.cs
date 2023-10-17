//Write a program in C# Sharp to read any digit, display in the word.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit;
            Console.WriteLine("Enter any degit(0 to 9)");
            digit = Convert.ToInt32(Console.ReadLine());
            switch(digit)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                case 0:
                    Console.WriteLine("Zero");
                    break;
            }
            Console.ReadKey();
        }
    }
}
