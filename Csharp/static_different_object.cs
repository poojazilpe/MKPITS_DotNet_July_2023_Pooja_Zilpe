using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_different_object
{
    class Program
    {
        class Book
        {
            static string title;
            static Book()
            {
                Console.WriteLine(" static constructor called");
                title = "Mkpits";
            }
            public void display()
            {
                Console.WriteLine("title : " + title);
            }
        }

        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.display(); //this will call static constructor only once
            Book b2 = new Book();
            b2.display(); // now static constructor will not be called;
            Console.ReadKey();

        }
    }
}
