using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Form_assignment_bank_account_customer
{
    public class Bank
    {

        List<Customer> cust;
        public Bank()
        {
            cust = new List<Customer>();
        }
        public void addcustomer(Customer customer)
        {
            cust.Add(customer);
        }
        public void display()
        {
            Console.WriteLine(cust);
        }

    }
    public class Customer
    {
        public string cname;
        List<Account> acc;
        public Customer(string cname)
        {
            this.cname = cname;
            acc = new List<Account>();
        }
        public void addaccount(Account account)
        {
            acc.Add(account);
        }

       
    }

    public class Account
    {
        public int id;
        public int bal = 1000;
        public int amt;
        public Account(int id, int amt)
        {
            this.id = id;
            this.amt = amt;
        }

        public void deposit()
        {
            bal = bal + amt;
        }
        public void withdrawl()
        {
            bal = bal - amt;
        }
        public void display()
        {
            Console.WriteLine("Account Details");
            
                Console.WriteLine("Account No : " + id);
                
                Console.WriteLine("Balance is : " + bal);
                Console.WriteLine("-------------------------------------");
            
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            while (true)
            {

                Console.WriteLine("Enter Name of customer: ");
                string cust1 = Console.ReadLine();
                Console.WriteLine("Enter Account no: ");
                int accno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Amount: ");
                int amt = Convert.ToInt32(Console.ReadLine());
                Customer c1 = new Customer(cust1);
                Account a1 = new Account(accno, amt);
                Console.WriteLine("Do you want to deposit or withdrawl");
                string choice = Console.ReadLine();
                if (choice == "deposit")
                {
                    a1.deposit();
                    a1.display();

                }
                else if (choice == "withdrawl")
                {
                    a1.withdrawl();
                    a1.display();

                }

            }

            




            Console.ReadKey();
        }
    }
}

