using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queue_collection_Customer
{
    class Program
    {
       class Customer
        {
            public int cust_id;
            public string name;
            public string email;
            public Customer(int cust_id,string name,string email)
            {
                this.cust_id = cust_id;
                this.name = name;
                this.email = email;
            }
        }
        static void Main(string[] args)
        {
            Customer c1 = new Customer(1,"Pooja","Poojazilpe1999@gmail.com");
            Customer c2 = new Customer(2, "Chandu", "Sonubopche1990@gmail.com");
            Customer c3 = new Customer(3, "Sonu", "chandu2000@gmail.com");
            Queue q = new Queue();
            q.Enqueue(c1);
            q.Enqueue(c2);
            q.Enqueue(c3);
            foreach(Customer c in q)
            {
                Console.WriteLine("Customer Id : " + c.cust_id);
                Console.WriteLine("Customer Name : " +c.name);
                Console.WriteLine("Customer Email: " + c.email);
            }
            Customer r = (Customer)q.Dequeue();
           
            Console.WriteLine("after deque ");
            foreach (Customer c in q)
            {
                Console.WriteLine("Customer Id : " + c.cust_id);
                Console.WriteLine("Customer Name : " + c.name);
                Console.WriteLine("Customer Email: " + c.email);

            }

            Console.ReadLine();


        }
    }
}
