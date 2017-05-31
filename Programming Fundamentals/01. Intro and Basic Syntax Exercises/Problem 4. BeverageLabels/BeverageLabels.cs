using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            //Input
            string beverageName = Console.ReadLine();
            double beverageVolume = double.Parse(Console.ReadLine());
            double energyContent = double.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());

            //Calculation
            double wholeEnergyContent = beverageVolume / 100 * energyContent;
            double wholeSugarContent = beverageVolume / 100 * sugarContent;

            //Printing

            Console.WriteLine($"{beverageVolume}" + "ml " + beverageName + ":");
            Console.WriteLine($"{wholeEnergyContent}" + "kcal, " + $"{wholeSugarContent}" + "g sugars");
        }
    }
}
