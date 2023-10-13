using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseMarksheet
{
    class Program
    {
        static void Main(string[] args)
        {
            int sub1, sub2, sub3, total;
            float per;
            string grade;
            Console.WriteLine("Enter 3 sub mark :");
            sub1 = Convert.ToInt32(Console.ReadLine());
            sub2 = Convert.ToInt32(Console.ReadLine());
            sub3= Convert.ToInt32(Console.ReadLine());
            total = sub1 + sub2 + sub3;
            per = (total / 300.0f) * 100.0f;
            Console.WriteLine("Total : {0}", total);
            Console.WriteLine("Percentage : {0}", per);
            if (per >= 75)
                grade = ("Distinction");
            else if(per>=60 && per<=75)
                grade = ("First Class");
            else if(per>=50 && per<=60)
                grade = ("Second class");
            else
                grade = ("Fail");
            Console.WriteLine("Grade : {0}", grade);
            Console.ReadKey();


        }
    }
}
