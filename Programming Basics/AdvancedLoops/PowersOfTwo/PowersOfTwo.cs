using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersOfTwo
{
    class PowersOfTwo
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int num = 1;
            //for (int i = 0; i <= n; i++)
            //{
            //    Console.WriteLine(num);
            //    num *= 2;
            double n = double.Parse(Console.ReadLine());
            double num;
            for (int i = 0; i <= n; i++)
            {
                num = Math.Pow(2, i);
                Console.WriteLine(num);
            }

        }
        
    }
}
