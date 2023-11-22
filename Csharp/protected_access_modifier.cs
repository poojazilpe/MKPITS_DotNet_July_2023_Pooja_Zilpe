using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protected_access_modifier
{
    class person
    {
        protected string name;
       
    }
    class student : person
    {
        public void msg()
        {
            name = "Pooja";
            Console.WriteLine("Name :" + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.msg();
            Console.ReadKey();
        }
    }
}
