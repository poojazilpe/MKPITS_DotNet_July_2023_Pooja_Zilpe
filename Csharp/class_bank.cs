using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_bank
{
    class Program
    {
        class Bank
        {
            string name;
            int acno;
            int bal = 1000;
            int withdrawl, deposite, amt;
            public void getdata(string name,int acno,int amt)
            {
                this.name = name;
                this.acno = acno;
                deposite = amt + bal;
                withdrawl = bal - amt;
            }
            public void displaydata()
            {
                Console.WriteLine("Name : " + name);
                Console.WriteLine("Acc No : " + acno);
                
                Console.WriteLine("After deposite : " + deposite);
                Console.WriteLine("After withdrawl : " + withdrawl);
            }
        }
        static void Main(string[] args)
        {
            Bank b = new Bank();
            Console.WriteLine("Enter name & acc no :");
             string n = Console.ReadLine();
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount :");
            int am = Convert.ToInt32(Console.ReadLine());
            b.getdata(n, a, am);
            b.displaydata();
            Console.ReadLine();

               



        }
    }
}
