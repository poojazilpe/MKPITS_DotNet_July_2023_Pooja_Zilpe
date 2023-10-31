using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_cust1
{
    class Program
    {
        class Customer
        {
            int customer_code;
            string customer_name;
            public void getdata(int cc, string cn)
            {
                customer_code = cc;
                customer_name = cn;
            }
            public void displaydata()
            {
                Console.WriteLine("Cusomer_code :" + customer_code);
                Console.WriteLine("Cusomer_name :" + customer_name);

            }
        }
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.getdata(123, "Pooja");
            cust.displaydata();
            Console.ReadKey();
        }
    }
}
