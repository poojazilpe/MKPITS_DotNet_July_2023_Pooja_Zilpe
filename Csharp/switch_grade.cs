/*Write a program in C# Sharp to accept a grade and declare the equivalent description :

Grade	Description
E	Excellent
V	Very Good
G	Good
A	Average
F	Fail */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char grade;
            Console.WriteLine("Enter grade(E,V,G,A,F)");
            grade = Convert.ToChar(Console.ReadLine());
            switch(grade)
            {
                case 'E':
                    Console.WriteLine("Exellant");
                    break;
                case 'V':
                    Console.WriteLine("Very good");
                    break;
                case 'G':
                    Console.WriteLine("Good");
                    break;
                case 'A':
                    Console.WriteLine("Average");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;

            }
            Console.ReadKey();

        }
    }
}
