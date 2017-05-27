using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class SumDigits
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num != 0)
            {
                int temp = num % 10;
                sum += temp;
                num = num / 10;
            }
            //for (int i = 0; i < num; i++)
            //{
            //    int temp = num % 10;
            //    sum += temp;
            //    num = num / 10;
            //}
            Console.WriteLine(sum);
        }
    }
}
