using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_marksheet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int total = 0;
            string grade;
            float per = 0.0f;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter number :");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                total = total+ num[i];
                per = (total / 500.0f) * 100.0f;
                
            }
            if(per>=75)
            {
                grade = "Distinction";
            }
            else if (per >= 60 && per<=75)
            {
                grade = "First";
            }
            else if (per >= 50 && per <= 60)
            {
                grade = "second";
            }
            else if (per >= 40 && per <= 40)
            {
                grade = "Third";
            }
            else 
            {
                grade = "Fail";
            }
            Console.WriteLine("Total = " + total);
            Console.WriteLine("Percentage = " + per);
            Console.WriteLine("Grade = " + grade);
            Console.ReadKey();
        }
    }
}
