using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heirachical_inheritance_person_student_employee
{
    class Person
    {
        string name;
        string address;
        public void getpersondata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displaypersondata()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Address : " + address);
        }
    }
    class student : Person
    {
        int rollno;
        int mark;
        public void getstudentdata(int rollno, int mark)
        {
            this.rollno = rollno;
            this.mark = mark;
        }
        public void displaystudentdata()
        {
            Console.WriteLine("Roll no : " + rollno);
            Console.WriteLine("mark : " + mark);
        }
    }
    class Employee : Person
    {
        int salary;
        string designation;
        public void getemployeedata(int salary, string designation)
        {
            this.salary = salary;
            this.designation = designation;
        }
        public void displayempdata()
        {
            Console.WriteLine("Salary : " + salary);
            Console.WriteLine("Designation : " + designation);
        }
        class Program
        {
            static void Main(string[] args)
            {
                student s = new student();
                s.getpersondata("Pooja", "Nagpur");
                s.getstudentdata(1001, 500);
                s.displaypersondata();
                s.displaystudentdata();
                Employee e = new Employee();
                e.getpersondata("sandy", "nagpur");
                e.getemployeedata(50000, "Manager");
                e.displaypersondata();
                e.displayempdata();
                Console.ReadKey();

            }
        }
    }
}


