using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_unique
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            
            int[] num = new int[3];
            for(int i=0;i<3;i++)
            {
                Console.Write("Enter Element {0}- ", i);
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<3;i++)
            {
                cnt = 0;
                for(int j=0;j<3;j++)
                {
                    if(i!=j)
                    {
                        if(num[i]==num[j])
                        {
                            cnt++;
                            break;
                        }
                    }

                }
                if(cnt==0)
                {
                    Console.WriteLine("Unique Element :{0}", num[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
