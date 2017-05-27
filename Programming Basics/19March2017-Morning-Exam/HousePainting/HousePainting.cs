using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePainting
{
    class HousePainting
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            //Calculating area walls

            double areaWallWindow = 2 * 1.2;
            double areaSquareWall = x * x;
            double areaSquareWalls = areaSquareWall + (areaSquareWall - areaWallWindow);
            double areaRectangularWalls = 2 * ((x * y) - Math.Pow(1.5, 2));
            double areaWalls = areaSquareWalls + areaRectangularWalls;

            //Calculating area roof

            double areaTrianglesRoof = 2 * (x * (h / 2));
            double areaRectangularRoof = 2 * (x * y);
            double areaRoof = areaTrianglesRoof + areaRectangularRoof;

            //Calculating Paint

            double greenPaint = areaWalls / 3.4;
            double redPaint = areaRoof / 4.3;

            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);

        }
    }
}
