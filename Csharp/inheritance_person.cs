using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_person
{
    class Person
    {
        public string name;
    }
    class Student: Person
    {
        public int rollno;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.name = "Pooja";
            s.rollno = 123;
            Console.WriteLine("Name : " + s.name);
            Console.WriteLine("Roll No : " + s.rollno);
            Console.ReadKey();
        }
    }
}
