using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_shape1
{
    public interface shape
    {
         void draw();
    }
    public class rectangle:shape
    {
        public void draw()
        {
            Console.WriteLine("draw shape rectangle...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            shape s = new rectangle();
            s.draw();
            Console.ReadKey();
        }
    }
}
