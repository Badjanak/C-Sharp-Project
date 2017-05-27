using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int f1 = 1;
            int f2 = 1;
            if (n < 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    sum = f1 + f2;
                    f1 = f2;
                    f2 = sum;
                }
                Console.WriteLine(sum); 
            }
        }
    }
}
