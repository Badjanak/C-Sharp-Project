using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Restaurant_Discount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            //Input
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            //Declaring variables
            string hallName = String.Empty;
            int hallPrice = 0;
            double discount = 0;
            int packagePrice = 0;

            //Logic statement
            if (groupSize > 0 && groupSize <= 50)
            {
                hallName = "Small Hall";
                hallPrice = 2500;                
            }
            if (groupSize > 50 && groupSize <= 100)
            {
                hallName = "Terrace";
                hallPrice = 5000;                
            }
            if (groupSize > 100 && groupSize <= 120)
            {
                hallName = "Great Hall";
                hallPrice = 7500;                
            }
                        
            switch (package)
            {
                case "Normal":
                    packagePrice = 500;
                    discount = 0.05;
                    break;
                case "Gold":
                    packagePrice = 750;
                    discount = 0.1;
                    break;
                case "Platinum":
                    packagePrice = 1000;
                    discount = 0.15;
                    break;
            }

            //Output
            if (hallPrice == 0)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                double totalPrice = (hallPrice + packagePrice);
                double discountPrice = totalPrice * discount;
                double finalPrice = totalPrice - discountPrice;
                double pricePerPerson = finalPrice / groupSize;
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
        }
    }
}
