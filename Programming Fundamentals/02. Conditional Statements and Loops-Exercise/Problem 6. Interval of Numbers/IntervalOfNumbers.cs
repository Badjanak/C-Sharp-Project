using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Interval_of_Numbers
{
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int m = Math.Min(firstNumber, secondNumber);
            int n = Math.Max(firstNumber, secondNumber);

            for (int i = m; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
