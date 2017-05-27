using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsdToBgn
{
    class UsdToBgn
    {
        static void Main(string[] args)
        {
            Console.Write("Input USD = ");
            double dollars = double.Parse(Console.ReadLine());
            double levas = dollars * 1.79549;
            Console.WriteLine(Math.Round(levas, 2));

        }
    }
}
