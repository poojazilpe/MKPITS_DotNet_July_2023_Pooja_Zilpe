using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sInheritance_method_protected_internal
{
    class Person
    {
        string name;
        string address;
        protected internal void getdata(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        protected internal void display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Address : " + address);
        }
    }
    class student : Person
    {
        int rollno;
        int mark;
        protected internal void getstudentdata(int rollno, int mark)
        {
            this.rollno=rollno;
            this.mark=mark;
        }
        protected internal void displaystudentdata()
        {
            Console.WriteLine("Roll no : " + rollno);
            Console.WriteLine("Mark : " + mark);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.getdata("Pooja", "Nagpur");
            s.getstudentdata(1001, 490);
            s.display();
            s.displaystudentdata();
            Console.ReadKey();
        }
    }
}
