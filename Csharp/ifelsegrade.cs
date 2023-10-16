using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelsegrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string grade;
            Console.WriteLine("Enter grade equvalent(E,G,V,A,F) :");
            grade = (Console.ReadLine());

            if(grade=="E")
            {
                Console.WriteLine("Excellent");
            }
            else if (grade == "V")
            {
                Console.WriteLine("Very good");
            }
            else if (grade == "G")
            {
                Console.WriteLine("Good");
            }
            else if (grade == "A")
            {
                Console.WriteLine("Average");
            }
            else if (grade == "F")
            {
                Console.WriteLine("Fail");
            }

            Console.ReadKey();
        }
    }
}
