using System;


namespace areaofcircle
{
    class Program
    {
        static void Main()
        {
            int radius;
            float area, coc;
            Console.WriteLine("Enter Radius :");
            radius = Convert.ToInt32(Console.ReadLine());
            area = 3.14f * radius * radius;
            coc = 2 * 3.14f * radius;
            Console.WriteLine("Area of Circle :" + area);
            Console.WriteLine("Circumferance of Circle :" + coc);
            Console.ReadKey();



        }
    }
}
