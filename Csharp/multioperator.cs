using System;


namespace @operator
{
    class Program
    {
        static void Main()

        {
            int num1, num2, result;
            Console.Write("Enter No 1 :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter No 2 :");
            num2 = Convert.ToInt32(Console.ReadLine());

            result = num1 + num2;
            Console.WriteLine("" +num1 + "+" + ""+ num2 + "=" + "" +result);

            result = num1 - num2;
            Console.WriteLine("" + num1 + "-" + "" + num2 + "=" + "" + result);

            result = num1 * num2;
            Console.WriteLine("" + num1 + "*" + "" + num2 + "=" + "" + result);

            result = num1 / num2;
            Console.WriteLine("" + num1 + "/" + "" + num2 + "=" + "" + result);

            result = num1 % num2;
            Console.WriteLine("" + num1 + "%" + "" + num2 + "=" + "" + result);

           
            Console.ReadKey();




        }
    }
}
