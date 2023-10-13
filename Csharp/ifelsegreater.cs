using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseIfgreater
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter no 1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no 2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no 3 : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
                Console.WriteLine("Greater no is : " +num1);
           else if (num2 > num3)
                Console.WriteLine("Greater no is : "+ num2);
            else 
                Console.WriteLine("Greater no is :" + num3);
            Console.ReadKey();


        }
    }
}
