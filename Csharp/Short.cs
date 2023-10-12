using System;

namespace shortUshort
{
    class Program
    {
        static void Main(string[] args)
        {
            short s;
            Console.WriteLine("Enter Number :");
            s = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Number = " + s);

            ushort s1;
            Console.WriteLine("Enter Number :");
            s1 = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Number = " + s1);
            Console.ReadKey();

        }
    }
}
