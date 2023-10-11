using System;


namespace swap
{
    class Program
    {
        static void Main()
        {
            int num1, num2, temp;
            Console.WriteLine("Enter no1 :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no2 :");
            num2 = Convert.ToInt32(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After Swap :");
            Console.WriteLine("num1 = "+num1);
            Console.WriteLine("num2 = " + num2);
            Console.ReadKey();




        }
    }
}
