using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_static
{
    class Book
    {
        static string title;
        static Book()
        {
            Console.WriteLine(" static constructor called");
            title = "Mkpits";
        }
        public static void display()
        {
            Console.WriteLine("title : " + title);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book.display();
            Console.ReadKey();

        }
    }
}
