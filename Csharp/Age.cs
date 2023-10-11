using System;


namespace age
{
    class Program
    {
        static void Main()
        {
            int age;
            Console.Write("Enter Age :");
            age= Convert.ToInt32(Console.ReadLine());
            if(age>20)
            {
                Console.WriteLine("You look older than " + age);
                Console.ReadKey();
            }
        }
    }
}
