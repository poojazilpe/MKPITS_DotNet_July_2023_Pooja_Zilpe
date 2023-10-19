using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_marksheet
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, total=0;
            float per=0;
            string grade;
            for(int cnt=1;cnt<=5;cnt++)
            {
                Console.WriteLine("Enter mark :");
                num = Convert.ToInt32(Console.ReadLine());
                total = total + num;
                per = (total / 500.0f) * 100.0f;
                
            }
            if(per>=75)
            {
                grade = "Distinction";
            }
            else if(per>=60 && per<=75)
            {
                grade = "First class";
            }
            else if (per >= 50 && per <= 60)
            {
                grade = "Second class";
            }
            else 
            {
                grade = "FAIL";
            }
            Console.WriteLine("Total = {0}", total);
            Console.WriteLine("Percentage = {0}", per);
            Console.WriteLine("Grade = {0}", grade);
            Console.ReadKey();

        }
    }
}
