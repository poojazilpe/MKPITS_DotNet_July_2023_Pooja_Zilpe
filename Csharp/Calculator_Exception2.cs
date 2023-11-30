using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorException2
{
    class calculate
    {
        public int a, b;
        public int res ;
        public void add(int a, int b)
        {
            res = a + b;
        }
        public void sub(int a, int b)
        {
            res = a - b;
        }
        public void mul(int a, int b)
        {
            res = a * b;
        }
        public void div(int a, int b)
        {
            if (a!=0 && b != 0)
            {
                res = a / b;
            }
            else
            {
                Console.WriteLine("Can not devide by zero");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            calculate c = new calculate();
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter no 1 :");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter no 2 :");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter choice :");
                    string choice = Console.ReadLine();

                    if(choice=="+")
                    {
                        c.add(a, b);
                        Console.WriteLine("Addition :" + c.res);
                        
                    }
                    else if (choice == "-")
                    {
                        c.sub(a, b);
                        Console.WriteLine("Substraction :" + c.res);

                    }
                    else if (choice == "*")
                    {
                        c.mul(a, b);
                        Console.WriteLine("Multiplication :" + c.res);

                    }
                    else if (choice == "/")
                    {
                        c.div(a, b);
                        Console.WriteLine("Division :" + c.res);

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());

                }
                Console.ReadKey();
            }
            
        }
    }
}
