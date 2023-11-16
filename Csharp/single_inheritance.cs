using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_inheritance
{
    class Employee
    {
        protected int salary;
    }
    class Programmer:Employee
    {
        int bonus;
        public void getdata(int salary,int bonus)
        {
            this.salary = salary;
            this.bonus = bonus;
        }
        public void displaydata()
        {
            Console.WriteLine("Salary : " + salary);
            Console.WriteLine("Bonus : " + bonus);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Programmer p = new Programmer();
            p.getdata(50000, 20000);
            p.displaydata();
            Console.ReadKey();
        }
    }
}
