using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first;
using first.second;
namespace first
{
    public class hello
    {
        public void sayhello()
        {
            Console.WriteLine("hello from first namespace");
        }
    }
    namespace second
    {
        public class welcome
        {
            public void sayhello()
            {
                Console.WriteLine("hello from second namespace");
            }
        }
    }
}
namespace namespace_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            hello h = new hello();
            h.sayhello();
            welcome w = new welcome();
            w.sayhello();
            Console.ReadKey();


        }
    }
}
