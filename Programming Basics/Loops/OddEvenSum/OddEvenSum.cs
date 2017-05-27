using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    int num = int.Parse(Console.ReadLine());
                    evenSum += num;
                }
                else
                {
                    int num = int.Parse(Console.ReadLine());
                    oddSum += num;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes\nSum = " + oddSum);
            }
            else
            {
                Console.WriteLine("No\nDiff = " + Math.Abs(evenSum-oddSum));
            }
        }
    }
}
