using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_inherit_method_person
{
    class Person
    {
        string address;
        string name;
        public void getdata(string address, string name)
        {
            this.address = address;
            this.name = name;
        }
        public void displaydata()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Address : " + address);
        }
    }
    class student : Person 
    {
        int rollno;
        int mark;
        public void getstudentdata(int rollno,int mark)
        {
            this.rollno=rollno;
            this.mark=mark;
        }
        public void displaystudentdata()
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
            s.getdata("Nagpur", "Pooja");
            s.getstudentdata(1001, 499);
            s.displaydata();
            s.displaystudentdata();
            Console.ReadKey();
        }
    }
}
