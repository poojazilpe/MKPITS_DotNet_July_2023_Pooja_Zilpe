using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_internal_acess_modifier
{
    class test
    {
        protected internal string name = "Minu";
        protected internal void msg(string msg)
        {
            Console.WriteLine("hello" + msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            test t = new test();
           
            Console.WriteLine("hello"+t.name);
            t.msg("pooja");
            Console.ReadKey();
        }
    }
}
