using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometersPerMonth = double.Parse(Console.ReadLine());
            double moneyPerKilometer = 0;


            switch (season)
            {
                case "Spring":
                case "Autumn":
                    if (kilometersPerMonth <= 5000)
                    {
                        moneyPerKilometer = 0.75;
                    }
                    if (kilometersPerMonth> 5000 & kilometersPerMonth <= 10000)
                    {
                        moneyPerKilometer = 0.95;
                    }
                    if (kilometersPerMonth > 10000 & kilometersPerMonth <= 20000)
                    {
                        moneyPerKilometer = 1.45;
                    }
                    break;
                case "Summer":
                    if (kilometersPerMonth <= 5000)
                    {
                        moneyPerKilometer = 0.90;
                    }
                    if (kilometersPerMonth > 5000 & kilometersPerMonth <= 10000)
                    {
                        moneyPerKilometer = 1.10;
                    }
                    if (kilometersPerMonth > 10000 & kilometersPerMonth <= 20000)
                    {
                        moneyPerKilometer = 1.45;
                    }
                    break;
                case "Winter":
                    if (kilometersPerMonth <= 5000)
                    {
                        moneyPerKilometer = 1.05;
                    }
                    if (kilometersPerMonth > 5000 & kilometersPerMonth <= 10000)
                    {
                        moneyPerKilometer = 1.25;
                    }
                    if (kilometersPerMonth > 10000 & kilometersPerMonth <= 20000)
                    {
                        moneyPerKilometer = 1.45;
                    }
                    break;

                default:
                    break;
            }
            double salary = 4 * kilometersPerMonth * moneyPerKilometer * 0.9;
            Console.WriteLine("{0:0.00}", salary);
        }
    }
}
