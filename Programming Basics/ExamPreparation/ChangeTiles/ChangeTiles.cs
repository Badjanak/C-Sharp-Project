using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            double savedMoney = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLong = double.Parse(Console.ReadLine());
            double triangleWidth = double.Parse(Console.ReadLine());
            double triangleH = double.Parse(Console.ReadLine());
            double oneTilePrice = double.Parse(Console.ReadLine());
            double workPrice = double.Parse(Console.ReadLine());
            double rectangleSurface = floorWidth * floorLong;
            double triangleSurface = (triangleWidth * triangleH) / 2.0;
            double tilesAmount = Math.Ceiling(rectangleSurface / triangleSurface) + 5;
            double allTilesPrice = oneTilePrice * tilesAmount;
            double finalPrice = allTilesPrice + workPrice;
            if (finalPrice > savedMoney)
            {                
                Console.WriteLine("You'll need {0:0.00} lv more.", Math.Abs(finalPrice - savedMoney));
            }
            else
            {                
                Console.WriteLine("{0:0.00} lv left.", Math.Abs(finalPrice - savedMoney));
            }            

        }
    }
}
