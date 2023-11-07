using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_oveloding_different_type_parameter
{
    class Calculate
    {
        public void addition(int n1,int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("Addition of 2 integer nos : " + res);
        }
        public void addition(float n1,float n2)
        {
            float res = n1 + n2;
            Console.WriteLine("Addition of 2 float nos : " + res);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculate c = new Calculate();
            c.addition(2, 3);
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Now calling addition float nos ");
            c.addition(2.3f, 3.3f);
            Console.ReadKey();
        }
    }
}
