using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseEligibleforadmission
{
    class Program
    {
        static void Main(string[] args)
        {
            int math, phy,che,total,total1;
            Console.WriteLine("Enter math mark:");
            math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter phy mark:");
            phy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter che mark:");
            che = Convert.ToInt32(Console.ReadLine());

            total = math + phy + che;
            total1 = math + total; //total marks of maths ans all three subjects = 160
            Console.WriteLine("Total in all three subject : "+total);

            

            if (math>=65 && phy>=55 && che>=50 && total>=180)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else if (total1 >= 160)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
            Console.ReadKey();
        }
    }
}
