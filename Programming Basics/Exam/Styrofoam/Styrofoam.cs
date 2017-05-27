using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam
{
    class Styrofoam
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double homeArea = double.Parse(Console.ReadLine());
            double winNumber = double.Parse(Console.ReadLine());
            double metersStyrofoamPerPack = double.Parse(Console.ReadLine());
            double priceStyrofoamPerPack = double.Parse(Console.ReadLine());

            double workArea = (homeArea - (winNumber * 2.4)) * 1.1;
            double numbersPackStyrofoamNeeded = Math.Ceiling(workArea / metersStyrofoamPerPack);
            double priceStyrofoam = numbersPackStyrofoamNeeded * priceStyrofoamPerPack;
            if (priceStyrofoam > budget)
            {
                Console.WriteLine("Need more: {0:0.00}", Math.Abs(priceStyrofoam - budget));
            }
            else
            {
                Console.WriteLine("Spent: {0:0.00}", priceStyrofoam);
                Console.WriteLine("Left: {0:0.00}", budget - priceStyrofoam);
            }
        }
    }
}
