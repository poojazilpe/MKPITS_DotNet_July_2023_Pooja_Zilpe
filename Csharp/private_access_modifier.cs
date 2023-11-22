using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace private_access_modifier
{
    class Program
    {
        private string name = "Shantosh Kumar";
        private void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("hello" + p.name);
            p.Msg("minu");
            Console.ReadKey();
        }
    }
}
