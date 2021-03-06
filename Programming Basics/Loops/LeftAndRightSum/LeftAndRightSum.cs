﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 1; i <= 2 * n; i++)
            {
                if (i <= n)
                {
                    int num = int.Parse(Console.ReadLine());
                    leftSum += num;
                }
                else
                {
                    int num = int.Parse(Console.ReadLine());
                    rightSum += num;
                }
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(rightSum - leftSum));
            }
        }
    }
}
