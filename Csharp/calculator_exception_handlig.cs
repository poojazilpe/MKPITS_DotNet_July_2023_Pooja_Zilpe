using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_exception_handling
{
    
    class calculate
    {
        double a, b;
       public double res = 0;
        public void add(double a,double b)
        {
             res = a + b;
        }
        public void sub(double a, double b)
        {
            res = a - b;
        }
        public void mul(double a, double b)
        {
            res = a * b;
        }
        public void div(double a, double b)
        {
            if (a != 0 && b != 0)
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
            c.add(5, 3);
            Console.WriteLine("Addition :" + c.res);

            c.sub(7, 6);
            Console.WriteLine("Substraction :" + c.res);

            c.mul(7, 5);
            Console.WriteLine("Multiplication :" + c.res);

            c.div(10, 0);
            Console.WriteLine("Division :" + c.res);
            Console.ReadKey();
        }
    }
}
