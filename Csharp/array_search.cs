using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            int flag = 0;
            int usernum;
            Console.WriteLine("enter number to be searched");
            usernum = Convert.ToInt32(Console.ReadLine()); //3
            for(int i=0;i<num.Length;i++)
            {
                if(num[i]==usernum)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("num {0} is found in an array", usernum);
            }
            else
            {
                Console.WriteLine("number is not found in an array");
            }


            Console.ReadKey();

        }
    }
}
