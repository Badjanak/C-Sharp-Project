using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Input y1 = ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Input x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Input y2 = ");
            double y2 = double.Parse(Console.ReadLine());
            double width = Math.Abs(x1-x2);
            double height = Math.Abs(y1 - y2);
            double area = width * height;
            double perimeter = (width + height) * 2;
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
