using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            switch (figure)
            {
                case "square":
                    Console.Write("a = ");
                    double square = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:0.000}",Math.Pow(square, 2));
                    break;
                case "rectangle":
                    Console.Write("a = ");
                    double rectangleA = double.Parse(Console.ReadLine());
                    Console.Write("b = ");
                    double rectangleB = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:0.000}", rectangleA *rectangleB);
                    break;
                case "circle":
                    Console.Write("r = ");
                    double circle = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:0.000}", Math.PI*circle*circle);
                    break;
                case "triangle":
                    Console.WriteLine("a = ");
                    double triangleA = double.Parse(Console.ReadLine());
                    Console.Write("ha = ");
                    double triangleHa = double.Parse(Console.ReadLine());
                    Console.Write("{0:0.000}", (triangleA*triangleHa)/2);
                    break;
            }
        }
    }
}
