using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Account
    {
        public int accno;
        public int bal = 1000;
        public abstract string deposit(int amt);
        public string withdrawl(int amt)
        {
            string res = null;
            if(amt>bal)
            {
                return "Insufficient Balance ";
            }
            else
            {
                bal = bal - amt;
                return "Withdrawl successfully, " + "Balance is : " + bal.ToString();
            }
        }
    }
    public class Saving : Account
    {
        public override string deposit(int amt)
        {
            int interest = 300;
            bal = bal + amt + interest;
            
           return "amount deposited successfully,balance is : " + bal.ToString();
        }
        
    }
    public class Current: Account
    {
        public override string deposit(int amt)
        {
            
            bal = bal + amt ;

            return "amount deposited successfully,balance is : " + bal.ToString();
        }

    }
}
