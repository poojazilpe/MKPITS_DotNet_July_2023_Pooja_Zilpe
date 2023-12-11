using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Bank_aacount_customer
{
    class Account
    {
        public string AccountNo { get; set; }
        public decimal Balance { get; set; }
        public Account(string AccountNo,decimal Balance)
        {
            this.AccountNo = AccountNo;
            this.Balance = Balance;
        }
        public void deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine("Deposit suceesfully, Balance is : " + Balance);
            
        }
        public void withdrawl(decimal amount)
        {
            if(amount>Balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Withdrawl suceesfully, Balance is : " + Balance);
            }
        }

    }
    class Customer
    {
        public string Name { get; set; }
        public List<Account> accounts = new List<Account>();
        public Customer(string Name)
        {
           this.Name = Name;
        }
        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }
        public decimal GetTotalBalance()
        {
           decimal totalbalance = 0;
            foreach(Account account in accounts)
            {
                totalbalance += account.Balance;
            }
            return totalbalance;
        }
    }
    class Bank
    {
        public List<Customer> customers = new List<Customer>();
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public void displayCustomerAccountDetails(string Name)
        {
            Customer customer = customers.Find(c => c.Name == Name);
            if(customer != null)
            {
                Console.WriteLine("Customer Name : " + Name);
                Console.WriteLine("Account Details : ");
                foreach(Account account in customer.accounts)
                {
                    Console.WriteLine("Accont No : " + account.AccountNo);
                    Console.WriteLine("Balance is : " + account.Balance);



                }
                Console.WriteLine("Total Balance: " + customer.GetTotalBalance());
                Console.WriteLine("---------------------------------");


            }
            else
            {
                Console.WriteLine("Customer not found");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            // Create customers and accounts
            Customer customer1 = new Customer("C1");
            Account account1 = new Account("A1", 1000);
            Account account2 = new Account("A2", 500);

            customer1.AddAccount(account1);
            customer1.AddAccount(account2);

            Customer customer2 = new Customer("C2");
            Account account3 = new Account("A3", 1500);

            customer2.AddAccount(account3);

            // Add customers to the bank
            bank.AddCustomer(customer1);
            bank.AddCustomer(customer2);

            // Display account details for a customer
            bank.displayCustomerAccountDetails("C1");
            bank.displayCustomerAccountDetails("C2");

            // Perform transactions
            account1.deposit(200);
            account2.withdrawl(300);
            account3.withdrawl(200);

            // Display updated account details
            bank.displayCustomerAccountDetails("C1");
            bank.displayCustomerAccountDetails("C2");
            Console.ReadKey();

        }
    }
}
