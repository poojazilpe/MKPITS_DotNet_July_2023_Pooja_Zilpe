using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sInheritance_protected_person_student
{
    class person
    {
        string name;
        string address;
        protected void getdata(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        protected void displaydata()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Address : " + address);
        }
    }
    class student : person
    {
        int rollno;
        int mark;
        public void getstudentdata(int rollno,int mark)
        {
            getdata("Pooja", "Nagpur");
            this.rollno = rollno;
            this.mark = mark;
        }
        public void displaystudentdata()
        {
            displaydata();
            Console.WriteLine("Roll no : " + rollno);
            Console.WriteLine("Mark : " + mark);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.getstudentdata(1001, 490);
            s.displaystudentdata();
            Console.ReadKey();
        }
    }
}
