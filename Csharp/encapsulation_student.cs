using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_student
{
    class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.id = 1;
            s.name = "Pooja";
            s.email = "Poojazilpe@1992";
            Console.WriteLine("Student Id :" + s.id);
            Console.WriteLine("Student Name :" + s.name);
            Console.WriteLine("Student Email :" + s.email);
            Console.ReadKey();


        }
    }
}
