using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string accommodation;
            string location;
            double price = 0;

            if (budget <= 1000)
            {
                accommodation = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.65;
                }
                else
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }                
                Console.WriteLine(location + " - " + accommodation + " - " + "{0:f2}", price);
            }

            if (budget > 1000 & budget <= 3000)
            {
                accommodation = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.8;
                }
                else
                {
                    location = "Morocco";
                    price = budget * 0.6;
                }
                Console.WriteLine(location + " - " + accommodation + " - " + "{0:f2}", price);
            }

            if (budget > 3000)
            {
                accommodation = "Hotel";
                price = budget * 0.9;

                if (season == "Summer")
                {
                    location = "Alaska";
                }
                else
                {
                    location = "Morocco";
                }

                //Alternative condition statement for SEASON using "Switch-Case"
                //switch (season)
                //{
                //    case "Summer":
                //        location = "Alaska";
                //        break;
                //    default:
                //        location = "Morocco";
                //        break;
                //}

                Console.WriteLine(location + " - " + accommodation + " - " + "{0:f2}", price);
            }
        }
    }
}
