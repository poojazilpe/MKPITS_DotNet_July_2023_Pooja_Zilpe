using System;


namespace addition2no
{
    class Program
    {
        static void Main()
        {
            int num1, num2, add;
            Console.WriteLine("Enter Number 1 :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2 :");
            num2 = Convert.ToInt32(Console.ReadLine());

            add = num1 + num2;

            Console.WriteLine("Addition of 2 nos = " + add);
            Console.ReadKey();


        }
    }
}
