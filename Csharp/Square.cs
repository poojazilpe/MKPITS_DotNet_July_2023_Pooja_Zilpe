using System;



namespace square
{
    class Program
    {
        static void Main()
        {
            int num, square;
            Console.WriteLine("Enter Number : ");
            num = Convert.ToInt32(Console.ReadLine());

            square = num * num;
            Console.WriteLine("Square = " + square);
            Console.ReadKey();


        }
    }
}
