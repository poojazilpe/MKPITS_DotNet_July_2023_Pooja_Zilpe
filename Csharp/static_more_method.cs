using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_moreMethod
{
    class student
    {
        public static void display()
        {
            Console.WriteLine("Hello");
        }
        public void sayhi()
        {
            Console.WriteLine("Hi");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            student.display();
            student s = new student();
            s.sayhi();
            Console.ReadKey();
        }
    }
}
