﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int num1 = int.Parse(Console.ReadLine());
            //int max = num1;
            //for (int i = 0; i < n - 1; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    if (num > max)
            //    {
            //        max = num;
            //    }
            //}
            //Console.WriteLine(max);
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
        }
    }
}
