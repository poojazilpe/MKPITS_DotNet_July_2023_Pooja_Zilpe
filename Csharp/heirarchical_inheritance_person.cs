using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heirarchi_Inheritance_Person
{
    class Person
    {
        public string name;
        public string address;
        
    }
    class Student : Person
    {
        public int rollno;
        public int mark;
    }
    class Employee : Person
    {
        public int salary;
        public string designation;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.rollno = 1001;
            s.name = "Pooja";
            s.address = "Nagpur";
            s.mark = 500;
            Console.WriteLine("--------------- Student Details ----------");
            Console.WriteLine("Name :" + s.name);
            Console.WriteLine("Addres :" + s.address);
            Console.WriteLine("Roll No :" + s.rollno);
            Console.WriteLine("Mark :" + s.mark);
            Console.WriteLine("------------------------------------------");
            Employee emp = new Employee();
            emp.name = "Pooja";
            emp.address = "Nagpur";
            emp.salary = 50000;
            emp.designation = "Manager";
            Console.WriteLine("--------------- Employee Details ----------");
            Console.WriteLine("Name :" + emp.name);
            Console.WriteLine("Addres :" + emp.address);
            Console.WriteLine("Salary :" + emp.salary);
            Console.WriteLine("Designation :" + emp.designation);
            Console.ReadKey();


        }
    }
}
