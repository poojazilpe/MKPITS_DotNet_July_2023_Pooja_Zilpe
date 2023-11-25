using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_bank
{
    interface bank
    {
        string deposit(int accno, int amt);
    }
    class saving : bank
    {
        int bal = 1000;
        int accno;
        public string deposit(int accno,int amt)
        {
            this.accno = accno;
            bal = bal + amt;
            return "accout no :" + accno +"\n"+ "Balance is : " + bal;
            

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bank b = new saving();
           string res= b.deposit(1, 500);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
