using System;


namespace divide2no
{
    class Program
    {
        static void Main()
        {
            int num1, num2, div;
            Console.Write("Enter no. 1 :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter no. 2 :");
            num2 = Convert.ToInt32(Console.ReadLine());

            div = num1 / num2;

            Console.WriteLine("Division : " + div);
            Console.ReadKey();

        }
    }
}
