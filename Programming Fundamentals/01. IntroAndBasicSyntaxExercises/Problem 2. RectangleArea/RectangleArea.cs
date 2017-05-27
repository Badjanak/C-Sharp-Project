using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            //Input
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            //Calculating
            double rectangleArea = width * height;

            //Printing
            Console.WriteLine($"{rectangleArea:f2}");

        }
    }
}
