using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_Inheritance_employee
{
    class Person
    {
        public string name;
        public string address;
    }
    class Employee : Person
    {
        public int empno;
        public int salary;
        public string designation;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.empno = 123;
            emp.name = "Pooja";
            emp.address = "Nagpur";
            emp.designation = "Manager";
            emp.salary = 50000;
            Console.WriteLine("Emp no : " + emp.empno);
            Console.WriteLine("Emp Name : " + emp.name);
            Console.WriteLine("Emp Address : " + emp.address);
            Console.WriteLine("Emp Designation : " + emp.designation);
            Console.WriteLine("Emp Salary : " + emp.salary);
            Console.ReadKey();


        }
    }
}
