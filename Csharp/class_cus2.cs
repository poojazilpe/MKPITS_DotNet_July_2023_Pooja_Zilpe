using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_cust2
{
    class Program
    {
        class Customer
        {
            int cust_code;
            string cust_name;
            public void getdata(int cust_code,string cust_name)
            {
                this.cust_code=cust_code;
                this.cust_name = cust_name;
            }
            public void displaydata()
            {
                Console.WriteLine("Customer code :" + cust_code);
                Console.WriteLine("Customer name :" + cust_name);
            }
        }
        static void Main(string[] args)
        {
            Customer custo = new Customer();
            Console.WriteLine("Enter customer code & customer name :");
            int cc = Convert.ToInt32(Console.ReadLine());
            string cn = Console.ReadLine();
            custo.getdata(cc, cn);
            custo.displaydata();
            Console.ReadKey();
        }
    }
}
