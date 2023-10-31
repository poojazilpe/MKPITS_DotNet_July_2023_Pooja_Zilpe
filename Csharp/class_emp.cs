using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_emp
{
    class Program
    {
        class Employee
        {
            int emp_no;
            int salary;
            string design;
            string emp_name;
            public void getdata(int en,string enm,string dn,int sal)
            {
                emp_no = en;
                emp_name = enm;
                design = dn;
                salary = sal;

            }
            public void displaydata()
            {
                Console.WriteLine("Emp no :" + emp_no);
                Console.WriteLine("Emp name :" + emp_name);
                Console.WriteLine("Designation :" + design);
                Console.WriteLine("Salary :" + salary);

            }
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getdata(123, "Pooja", "Manager", 50000);
            emp.displaydata();
            Console.ReadKey();

        }
    }
}
