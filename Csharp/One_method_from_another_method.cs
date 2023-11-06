using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_method_from_another_method
{
    class Program
    {
        class Book
        {
            string title, author;

            public void getdata(string title)
            {
                Console.WriteLine("method with one parameter");
                getdata(title, "Pooja");  //calling method with 2 parameters
            }
            public void getdata(string title, string author)
            {
                Console.WriteLine("method with 2 parameter");
                this.title = title;
                this.author = author;
            }

            public void display()
            {
                Console.WriteLine("Title : " + title);
                Console.WriteLine("Author : " + author);
            }
        }

        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.getdata("HTML");
            b1.display();
            Console.ReadKey();

        }
    }
}
