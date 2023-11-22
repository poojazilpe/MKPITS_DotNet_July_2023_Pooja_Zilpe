using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_class_feild
{
    abstract class person
    {
        public string name;
    }
    class student : person
    {
        public int rno;
    }
    sealed class parttimes : student
    {
        public int hr;
    }
    /*
class newstudent : parttimestudent //error
{

}
*/

    class Program
    {
        static void Main(string[] args)
        {
            parttimes p = new parttimes();
            p.rno = 22;
            p.name = "Pooja";
            p.hr = 5;
            Console.WriteLine("Roll no " + p.rno);
            Console.WriteLine("Name " + p.name);
            Console.WriteLine("hours " + p.hr);
            Console.ReadKey();

        }
    }
}
