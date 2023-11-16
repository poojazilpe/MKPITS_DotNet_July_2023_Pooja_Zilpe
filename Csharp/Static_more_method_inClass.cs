using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_moremethod_inClass
{
    class Book
    {
        public static int bookid;
        public static void display()

        {
            Console.WriteLine("Hello from static display method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book.bookid = 12;
            Book.display();
            Program p = new Program();
            p.Main();
            Console.WriteLine("Book Id : " + Book.bookid);
            Console.ReadKey();
        }
        void Main()
        {
            Console.WriteLine("hello from another main method");
        }
    }
}
