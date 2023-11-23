using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arraylist_student_rollno
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(1);
            ar.Add(2);
            ar.Add(3);
            foreach(object o in ar)
            {
                Console.WriteLine("Student Roll No : " + o);
            }
            Console.WriteLine("Capacity {0}: " + ar.Capacity);
            Console.WriteLine("Capacity {1}: " + ar.Count);
            Console.ReadKey();




        }
    }
}
