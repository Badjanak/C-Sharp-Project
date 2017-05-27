using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string product = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    price = quantity * 0.5;
                }
                else if (product == "water")
                {
                    price = quantity * 0.8;
                }
                else if (product == "beer")
                {
                    price = quantity * 1.2;
                }
                else if (product == "sweets")
                {
                    price = quantity * 1.45;
                }
                else if (product == "peanuts")
                {
                    price = quantity * 1.60;
                }
            }
            Console.WriteLine(price);

        }
    }
}
