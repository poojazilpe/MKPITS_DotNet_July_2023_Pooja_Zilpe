using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argument_outof_memory_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Pooja";
            string sub = "Csharp";
            Console.WriteLine("length of name : "+name.Length);
            StringBuilder sb = new StringBuilder(name.Length,name.Length);
            try
            {
                sb.Append(sub);
            }
            catch(ArgumentOutOfRangeException ae)
            {
                Console.WriteLine(ae.ToString());
            }
            Console.ReadKey();

        }
    }
}
