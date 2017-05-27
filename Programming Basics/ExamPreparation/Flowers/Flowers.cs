using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            double chrysanthemum = double.Parse(Console.ReadLine());
            double roses = double.Parse(Console.ReadLine());
            double tulips = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();
            double priceBouquet = 0;
            double priceFlowers = 0;

            if (season == "Spring" || season == "Summer")
            {
                double priceChrysanthemum = chrysanthemum * 2.0;
                double priceRoses = roses * 4.10;
                double priceTulips = tulips * 2.50;
                priceFlowers = priceChrysanthemum + priceRoses + priceTulips;

                if (holiday == "Y")
                {
                    priceFlowers = priceFlowers * 1.15;
                }
                if (tulips > 7 && season == "Spring")
                {
                    priceFlowers = priceFlowers * 0.95;
                }
                if (chrysanthemum + roses + tulips > 20)
                    {
                        priceFlowers = priceFlowers * 0.80;
                    }
                
                priceBouquet = priceFlowers + 2;
                Console.WriteLine("{0:0.00}", priceBouquet);
            }
            else
            {
                double priceChrysanthemum = chrysanthemum * 3.75;
                double priceRoses = roses * 4.50;
                double priceTulips = tulips * 4.15;
                priceFlowers = priceChrysanthemum + priceRoses + priceTulips;

                if (holiday == "Y")
                {
                    priceFlowers = priceFlowers * 1.15;
                }
                if (roses >= 10 && season == "Winter")
                {
                    priceFlowers = priceFlowers * 0.90;
                }
                if (chrysanthemum + roses + tulips > 20)
                {
                    priceFlowers = priceFlowers * 0.80;
                }

                priceBouquet = priceFlowers + 2;
                Console.WriteLine("{0:0.00}", priceBouquet);
            }


        }
                   

            
            
        }
    }

