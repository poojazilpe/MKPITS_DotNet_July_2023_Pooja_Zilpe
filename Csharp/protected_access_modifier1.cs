using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protected_access_modifier1
{
    class test
    {
        protected string name = "Pooja Zilpe";
        protected void msg(string msg)
        {
            Console.WriteLine("Hello" + msg);
        }
    }
    class Program : test
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Name :" + p.name);
            p.msg("Shashwat");
            Console.ReadKey();

        }
    }
}
