﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Odd_Number
{
    class OddNumber
    {
        static void Main(string[] args)
        {            
                       
            {
                while (true)
                {
                    int number = Math.Abs(int.Parse(Console.ReadLine()));
                    if (number % 2 != 0)
                    {
                        Console.WriteLine($"The number is: {number}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please write an odd number.");
                    }
                }
            }
        }
    }
}
