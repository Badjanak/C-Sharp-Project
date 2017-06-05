using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Choose_a_Drink_2._0
{
    class ChooseADrink2
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double totalPrice;

            switch (profession)
            {
                case "Athlete":
                    totalPrice = quantity * 0.7;
                    break;
                case "Businessman":
                case "Businesswoman":
                    totalPrice = quantity * 1.0;
                    break;
                case "SoftUni Student":
                    totalPrice = quantity * 1.7;
                    break;
                default:
                    totalPrice = quantity * 1.2;
                    break;
            }
            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
        }
    }
}
