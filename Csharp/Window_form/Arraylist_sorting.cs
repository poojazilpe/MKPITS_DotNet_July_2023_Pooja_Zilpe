using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arraylist_sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(11);
            ar.Add(2);
            ar.Add(33);
            Console.WriteLine("Arraylist without sorting.");
            foreach (object o in ar)
            {
                Console.WriteLine("Student Roll No : " + o);
            }
            Console.WriteLine("------------------");
            ar.Sort();
            Console.WriteLine("Arraylist with sorting.");
            foreach (object o in ar)
            {
                Console.WriteLine("Student Roll No : " + o);
            }
            Console.ReadKey();
        }
    }
}
