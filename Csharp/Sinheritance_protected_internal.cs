using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinheritance_protected_Internal
{
    class Person
    {
        string name;
        protected void getpersondata(string name)
        {
            this.name = name;
            Console.WriteLine("Name : " + name);
        }
    }
    class employee : Person
    {
        int empno;
        internal void getstudentdata(int empno,string name)
        {
            getpersondata(name);
            this.empno = empno;
            Console.WriteLine("Emp no : " + empno);

        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee e = new employee();
            e.getstudentdata(1001, "Pooja");
            Console.ReadKey();
        }
    }
}
