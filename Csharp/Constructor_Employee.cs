using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Employee
{
    class Employee
    {
        int EmpId, Salary;
        string Name, Designation;
        public Employee()
        {
            EmpId = 1;
            Name = "Pooja";
            Designation = "Manager";
            Salary = 50000;
        }
        public void display()
        {
            Console.WriteLine("Employee Id :" + EmpId);
            Console.WriteLine("Employee Name :" + Name);
            Console.WriteLine("Employee Designation :" + Designation);
            Console.WriteLine("Employee Salary :" + Salary);
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.display();
            Console.ReadKey();
        }
    }
}
