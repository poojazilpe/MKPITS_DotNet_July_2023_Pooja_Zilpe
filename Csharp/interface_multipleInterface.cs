using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_multipleInterface
{
    interface Ireadable
    {
        string readdata();
        string writedata(string data);
    }
    interface Iwritable
    {
        string readdata();
        string writedata(string data);
    }
    class filehandler :Ireadable,Iwritable
    {
        public string readdata()
        {
            return "readdata";
        }
        public string writedata(string data)
        {
            return "Writedata";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ireadable r = new filehandler();
            string res = r. readdata();
            Console.WriteLine(res);

            Iwritable w = new filehandler();
            string res1 = w.writedata("data");
            Console.WriteLine(res1);

            Ireadable r1 = new filehandler();
            string res2 = r1.readdata();
            Console.WriteLine(res2);

            Iwritable w1 = new filehandler();
            string res3 = w1.writedata("data");
            Console.WriteLine(res3);
            Console.ReadKey();
        }
    }
}
