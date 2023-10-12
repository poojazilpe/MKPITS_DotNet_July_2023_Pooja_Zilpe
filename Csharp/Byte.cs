using System;


namespace byteSbyte
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b;
            Console.Write("Enter Number :");
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Byte Number = " + b);

            sbyte b1;
            Console.Write("Enter Number :");
            b1 = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Byte Number = " + b1);
            Console.ReadKey();


        }
    }
}
