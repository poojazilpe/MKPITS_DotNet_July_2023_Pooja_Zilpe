using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstact_class_person
{
    abstract class person
    {
        public abstract void display();
        public void show()
        {
            Console.WriteLine("hello from showdata");
        }
    }
    class student : person
    {
        public override void display()
        {
            Console.WriteLine("Hello from display method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.display();
            s.show();
            Console.ReadKey();
               
        }
    }
}
