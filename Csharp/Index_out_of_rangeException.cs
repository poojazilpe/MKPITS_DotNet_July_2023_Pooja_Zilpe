using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_out_of_rangeException
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            try
            {
                for(int i=0;i<=3;i++)
                {
                    Console.WriteLine("Array : " + arr[i]);
                }
            }
            catch(IndexOutOfRangeException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            catch(Exception ee)
            {
                Console.WriteLine("catch  is executed");
                Console.WriteLine(ee.ToString());
            }
            finally
            {
                Console.WriteLine("finally is executed");
            }
            Console.ReadKey();
        }
        
    }
}
