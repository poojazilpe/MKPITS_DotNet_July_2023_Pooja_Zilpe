﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter Number :");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Reverse No :");
            for (int i = 2; i >= 0; i--)
            {
                Console.Write("{0}",num[i]);
                
            }
            Console.ReadKey();

        }
    }
}
