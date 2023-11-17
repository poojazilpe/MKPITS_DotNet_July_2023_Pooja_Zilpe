using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_inheritance_person
{
    class Person
    {
        public string name;
        public string address;
    }
    class Student: Person
    {
        public int rollno;
        public int mark;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.rollno = 123;
            s.name = "Pooja";
            s.address = "Nagpur";
            s.mark = 499;
            Console.WriteLine("Roll No. : " + s.rollno);
            Console.WriteLine("Name : " + s.name);
            Console.WriteLine("Address : " + s.address);
            Console.WriteLine("Mark : " + s.mark);
            Console.ReadKey();
        }
    }
}
