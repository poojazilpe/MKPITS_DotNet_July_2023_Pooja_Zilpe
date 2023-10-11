using System;


namespace avrage
{
    class avrage
    {
        static void Main()
        {
            int n1, n2, n3, n4, avg;
            Console.Write("Enter no1 :");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter no2 :");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter no3 :");
            n3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter no4 :");
            n4 = Convert.ToInt32(Console.ReadLine());

            avg = (n1 + n2 + n3 + n4 )/ 4;

            Console.WriteLine("Average = " + avg);
            Console.ReadKey();
        }
    }
}
