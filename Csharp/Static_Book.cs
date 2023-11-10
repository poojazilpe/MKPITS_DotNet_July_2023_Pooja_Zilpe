using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Book
{
    class Book
    {
        public static int bookid;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book.bookid = 12;
            Console.WriteLine("Book Id: " + Book.bookid);
            Console.ReadKey();
        }
    }
}
