using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_inheritance_method_emp
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
    class Employee : Person
    {
        int empno;
        int salary;
        public void getEmployeedata(int empno,int salary)
        {
            this.empno=empno;
            this.salary=salary;
        }
        public void displayEmployeedata()
        {
            Console.WriteLine("Emp No : " + empno);
            Console.WriteLine("Salary : " + salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.getdata("Nagpur", "Pooja");
            e.getEmployeedata(1001, 50000);
            e.displaydata();
            e.displayEmployeedata();
            Console.ReadKey();
        }
    }
}
