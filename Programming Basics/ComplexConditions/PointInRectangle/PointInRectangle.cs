using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInRectangle
{
    class PointInRectangle
    {
        static void Main(string[] args)
        {
            //Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            //Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine());
            //Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            //Console.Write("y2 = ");
            double y2 = double.Parse(Console.ReadLine());
            //Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            //Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());
            bool isInside = (x >=x1 && x <= x2) && (y >= y1 && y <= y2);
            if (isInside)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
            {

            }

        }
    }
}
