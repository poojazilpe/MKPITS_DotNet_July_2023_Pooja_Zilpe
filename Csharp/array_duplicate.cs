using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int cnt = 0;
            int[] num = new int[3];
            for( i=0;i<3;i++)
            {
                Console.WriteLine("Enter Number :");
                num[i] = Convert.ToInt32(Console.ReadLine());

            }
            for ( i = 0; i < 3; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    if(num[i]==num[j])
                    {
                        cnt++;
                        break;
                    }

                        
                }       

                
            }
            Console.WriteLine("Dulicate no  :" + cnt);

            Console.ReadKey();

        }
    }
}
