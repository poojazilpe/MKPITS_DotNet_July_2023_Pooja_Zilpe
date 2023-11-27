using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            li.Add("C");
            li.Add("C++");
            li.Add("C#");
            Console.WriteLine(li.Contains("C#"));
            Console.WriteLine(li[1]);
            li.Remove("C#");
            Console.WriteLine(li.Contains("C#"));
            li.Insert(1, "Java");
            li.Sort();
            foreach(string s in li)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
