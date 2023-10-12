using System;


namespace longUlong
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine("Enter Number :");
            a = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Number = " + a);

            ulong b;
            Console.WriteLine("Enter Number :");
            b = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Number = " + b);
            Console.ReadKey();
        }
    }
}
