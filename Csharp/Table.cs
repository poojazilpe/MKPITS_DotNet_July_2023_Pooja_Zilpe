using System;


namespace table
{
    class Program
    {
        static void Main()
        {
            int num, cnt, result;
            Console.WriteLine("Enter Number : ");
            num = Convert.ToInt32(Console.ReadLine());

            for(cnt=0;cnt<=10;cnt++)
            {
                result = num * cnt;
                Console.WriteLine("" + num + "*" + "" + cnt + "=" + "" + result);
            }
            Console.ReadKey();
        }
    }
}
