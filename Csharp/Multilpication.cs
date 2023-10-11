using System;

namespace multiplication
{
    class Program
    {
        static void Main()

        {
            int num1, num2,num3, mul;
            Console.Write("Enter No 1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter No 2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter No 3 : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            mul = num1 * num2 * num3;

            Console.WriteLine("Multiplication = " + mul);
            Console.ReadKey();


        }
    }
}
