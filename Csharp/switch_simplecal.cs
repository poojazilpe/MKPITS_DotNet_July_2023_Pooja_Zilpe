//Write a program in C# Sharp which is a menu-driven program to perform simple calculations.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_simplecal
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,choice, result;
            Console.WriteLine("Enter no 1 :");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no 1 :");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            Console.WriteLine("Enter your choice :");
            choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine("Addition = {0}", result);
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine("Subtraction = {0}", result);
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine("Multipication = {0}", result);
                    break;
                case 4:
                    result = num1 / num2;
                    Console.WriteLine("Division = {0}", result);
                    break;

            }

            Console.ReadKey();
        }
    }
}
