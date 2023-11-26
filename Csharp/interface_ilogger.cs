using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ilogger
{
    interface ILogger
    {
        string Logmessage(string message);
        string Errormessage(string message);

    }
    class Consolelogger : ILogger
    {
        public string Logmessage(string message)
        {
            return "Massage";
        }
        public string Errormessage(string message)
        {
            return " Error Massage";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ILogger l ;
            l = new Consolelogger();
            string res = l.Logmessage("hii");
            Console.WriteLine(res);
            res = l.Errormessage("error");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
