using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Emp_para
{
    class Employee
    {
        int empid, salary;
        string name, designation;
        public Employee(int empid,string name,string designation,int salary)
        {
            this.empid = empid;
            this.name = name;
            this.designation = designation;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine("Employee Id :" + empid);
            Console.WriteLine("Employee Name :" + name);
            Console.WriteLine("Employee Designation :" + designation);
            Console.WriteLine("Employee Salary :" + salary);
        }
            

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee e = new Employee(1,"Pooja","Manager",50000);
            e.display();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Enter Employee Id :");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name :");
            string n = (Console.ReadLine());

            Console.WriteLine("Enter Employee Designation:");
            string d = (Console.ReadLine());

            Console.WriteLine("Enter Employee Salary:");
            int s = Convert.ToInt32(Console.ReadLine());

            Employee e1 = new Employee(i, n, d, s);
            e1.display();
            Console.ReadKey();
        }
    }
}
