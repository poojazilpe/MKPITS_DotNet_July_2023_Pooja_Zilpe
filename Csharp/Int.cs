using System;


namespace IntUInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter Number :");
           n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number = " + n);

            uint n1;
            Console.WriteLine("Enter Number :");
            n1 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Number = " + n1);

            Console.ReadKey();
        }
    }
}
