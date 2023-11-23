using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace arraylist_collection_student_name
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Pooja");
            ar.Add("Chandrima");
            ar.Add("Kareena");
            foreach(object obj in ar)
            {
                Console.WriteLine("Student Name : " + obj);
            }
            Console.ReadKey();
        }
    }
}
