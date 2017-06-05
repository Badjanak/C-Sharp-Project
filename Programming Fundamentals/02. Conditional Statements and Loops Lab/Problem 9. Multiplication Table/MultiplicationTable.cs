using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Multiplication_Table
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());

            for (int times = 1; times <= 10; times++)
            {
                Console.WriteLine($"{integer} X {times} = {integer * times}");
            }
        }
    }
}
