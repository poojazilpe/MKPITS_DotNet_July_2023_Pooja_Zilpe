using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_defined_exceptionage
{
    public class AgeException : ApplicationException
    {
        public AgeException(string message) : base(message)
        {
        }

    }
    class Age
    {
        int age=12;
        public void show()
        {
            if(age<=18)
            {
                throw new AgeException(" not Eligible for vote");
            }
            else
            {
                Console.WriteLine("Age= " + age);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Age a = new Age();
            try
            {
                a.show();
            }
            catch(AgeException e)
            {
                Console.WriteLine("AgeException : " + e.ToString());
            }
            Console.ReadKey();
            
        }
    }
}
