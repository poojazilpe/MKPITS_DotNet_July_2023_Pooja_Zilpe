using System;
using System.Collections.Generic;


namespace programx
{
    class Program
    {
        static void Main()
        {
            int x, y, z, res;
            Console.Write("Enter no 1 :");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter no 2 :");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter no 3 :");
            z = Convert.ToInt32(Console.ReadLine());

            res = (x + y)*z;
            Console.WriteLine("Result = " + res);

            res= x * y + y * z;
            Console.WriteLine("Result = " + res);


            Console.ReadKey();

        }
    }
}
