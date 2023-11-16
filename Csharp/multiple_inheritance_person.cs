using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_inheritance_peson
{
    class Person
    {
        string address;
        string name;
        public void getpersondata(string address,string name)
        {
            this.address = address;
            this.name = name;
        }
        public void displaypersondata()
        {
            Console.WriteLine("Address : " + address);
            Console.WriteLine("Name : " + name);
        }
    }
    class Employee : Person
    {
        int empno;
        int salary;
        public void getemployeedata(int empno, int salary)
        {
            this.empno=empno;
            this.salary=salary;
        }
        public void displayemployeedata()
        {
            Console.WriteLine("Emp no : " + empno);
            Console.WriteLine("Salary : " + salary);
        }
    }
    class Parttime : Employee
    {
        int parttimehr;
        public void getdata(int parttimehr)
        {
            this.parttimehr=parttimehr;
            
        }
        public void displaydata()
        {
            Console.WriteLine("Part Time hr : " + parttimehr);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parttime p = new Parttime();
            p.getpersondata("Nagpur", "Pooja");
            p.getemployeedata(1001, 50000);
            p.getdata(5);
            p.displaypersondata();
            p.displayemployeedata();
            p.displaydata();
            Console.ReadKey();

        }
    }
}
