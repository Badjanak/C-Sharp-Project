using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }
            if (maxNum == sum - maxNum)
            {
                Console.WriteLine("Yes\nSum = " + maxNum);
            }
            else
            {
                Console.WriteLine("No\nDiff = " + Math.Abs(maxNum - (sum - maxNum)));
            }
        }
    }
}
