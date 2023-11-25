using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace stack_collection_Employee
{
    class Employee
    {
        public int empno;
        public string name;
        public int salary;
        public string design;
        public Employee(int empno,string name, int salary,string design)
        {
            this.empno = empno;
            this.name = name;
            this.salary = salary;
            this.design = design;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1,"Pooja",50000,"Manager");
            Employee e2 = new Employee(1, "Akash", 45000, "Manager");
            Employee e3 = new Employee(1, "Chandrima", 40000, "Manager");
            Stack st = new Stack();
            st.Push(e1);
            st.Push(e2);
            st.Push(e3);
            foreach(Employee e in st)
            {
                Console.WriteLine("Employee Id :" + e.empno);
                Console.WriteLine("Employee Name :" + e.name);
                Console.WriteLine("Employee Salary :" + e.salary);
                Console.WriteLine("Employee Designation:" + e.design);
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            Console.WriteLine("After pop");
            st.Pop();
            foreach (Employee e in st)
            {
                Console.WriteLine("Employee Id :" + e.empno);
                Console.WriteLine("Employee Name :" + e.name);
                Console.WriteLine("Employee Salary :" + e.salary);
                Console.WriteLine("Employee Designation:" + e.design);
            }
            Console.ReadKey();
        }
    }
}
