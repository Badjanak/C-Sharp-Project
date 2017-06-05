using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Test_Numbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maximumSumBoundary = int.Parse(Console.ReadLine());
            int product = 0;
            int totalSum = 0;
            int counterCombination = 0;

            for (int nCircle = n; nCircle >= 1; nCircle--)
            {
                for (int mCircle = 1; mCircle <= m; mCircle++)
                {                    
                    if (totalSum >= maximumSumBoundary)
                    {
                        Console.WriteLine($"{counterCombination} combinations");
                        Console.WriteLine($"Sum: {totalSum} >= {maximumSumBoundary}");
                        return;
                    }
                    else
                    {
                        counterCombination++;
                        product = (nCircle * mCircle) * 3;
                        totalSum += product;
                    }
                }
            }
            Console.WriteLine($"{counterCombination} combinations");
            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}
