using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace public_acess_midifier
{
    class test
    {
        public string name = "Pooja Zilpe";
        public void msg(string msg)
        {
            Console.WriteLine("Hello"+msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            test t = new test();
            Console.WriteLine("Hello"+t.name);
            t.msg("Sandy Tambe");

            Console.ReadKey();
        }
    }
}
