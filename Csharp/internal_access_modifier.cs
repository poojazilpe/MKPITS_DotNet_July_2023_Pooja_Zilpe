using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internal_class
{
    class test
    {
        internal string name = "Pooja";
        internal void msg(string msg)
        {
            Console.WriteLine("hello" + msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            test t = new test();
            Console.WriteLine("Name :" + t.name);
            t.msg("minu");
            Console.ReadKey();
        }
    }
}
