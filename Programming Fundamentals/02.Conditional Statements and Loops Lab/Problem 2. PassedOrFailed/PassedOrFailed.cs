using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.PassedOrFailed
{
    class PassedOrFailed
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 2 && grade <= 6)
            {
                if (grade > 2.99)
                {
                    Console.WriteLine("Passed!");
                }
                else
                {
                    Console.WriteLine("Failed!");
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }


        }
    }
}
