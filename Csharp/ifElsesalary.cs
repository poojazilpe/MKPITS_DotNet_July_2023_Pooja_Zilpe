using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            int empno; 
            string empname;
            int basic_salary;
            string designation;
            float bonus = 0;
            float total_salary ;
            Console.WriteLine("Enter Emp no : ");
            empno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Emp name : ");
            empname =(Console.ReadLine());

            Console.WriteLine("Enter Basic Salary : ");
            basic_salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Designation : ");
            designation = (Console.ReadLine());

            if(designation=="manager")
            {
                bonus = basic_salary * 0.55f;
            }
            else if (designation == "clerk")
            {
                bonus = basic_salary * 0.25f;
            }
            else if (designation == "peon")
            {
                bonus = basic_salary * 0.10f;
            }
            total_salary = basic_salary + bonus;
            Console.WriteLine("Emp No:{0} Emp name:{1} salary:{2} designation : {3} ",empno,empname,basic_salary,designation);
            Console.WriteLine("Bonus : {0}", bonus);
            Console.WriteLine("Total Salary : {0}",total_salary);
            Console.ReadKey();



        }
    }
}
