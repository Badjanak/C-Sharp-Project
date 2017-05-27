using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int temp;
            while (B != 0)
            {
                temp = A % B;
                A = B;
                B = temp;
            }
            Console.WriteLine(A);
        }
    }
}
