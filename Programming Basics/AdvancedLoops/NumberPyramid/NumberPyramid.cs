using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class NumberPyramid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int row = 1; row <= i; row++)
                {
                    Console.Write(num + " ");                    
                    num += 1;
                    if (num > n)
                    {
                        Console.WriteLine();
                        return;
                    }
                }
                Console.WriteLine();
                
            }
        }
    }
}
