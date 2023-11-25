using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace default_interface_method_ilogger
{
    interface ILogger
    {
        string Logmessage(string message);
        string Errormessage(string message);
        string loginfo(string logmessage);

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
        public string loginfo(string logmessage)
        {
            return " Log info Massage";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ILogger l = new Consolelogger();
            string res=l.Logmessage("hii");
            Console.WriteLine(res);
            res=l.Errormessage("error");
            Console.WriteLine(res);
            res = l.loginfo("info");
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
