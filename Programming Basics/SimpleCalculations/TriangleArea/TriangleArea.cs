using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            Console.Write("Input a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input h = ");
            double h = double.Parse(Console.ReadLine());
            double area = a * h / 2;
            Console.WriteLine("Triangle area = " + Math.Round(area, 2));
        }
    }
}
