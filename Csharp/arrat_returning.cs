﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_returning
{
    class Program
    {
        static int[] returnarray()
        {
            int[]num= { 1, 2, 3 };
            return num;
            
        }

        static void Main(string[] args)
        {
            int[] res = returnarray();
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
