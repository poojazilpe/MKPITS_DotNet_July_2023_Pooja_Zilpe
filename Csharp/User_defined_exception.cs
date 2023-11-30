using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_defined_Exception
{
    public class Tempexception : ApplicationException
    {
        public Tempexception(string message) : base(message)
        {

        }
    }
    class Temperature
    {
        int temp=22;
        public void show()
        {
            if(temp==0)
            {
                throw new Tempexception("Zero temperature found");
            }
            else
            {
                Console.WriteLine("Temperature : " + temp);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Temperature t = new Temperature();
            try
            {
                t.show();
            }
            catch(Tempexception e)
            {
                Console.WriteLine("Temperature Exception :" + e.Message);
            }
            Console.ReadKey();
        }
    }
}
