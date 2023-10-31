using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_customer
{
    class Program
    {
        class Customer
        {
           public int customer_code;
             public string customer_name;
        }
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.customer_code = 123;
            cust.customer_name = "Pooja";
            Console.WriteLine("Customer_code :" + cust.customer_code);
            Console.WriteLine("Customer_name :" + cust.customer_name);
            Console.ReadKey();

        }
    }
}
