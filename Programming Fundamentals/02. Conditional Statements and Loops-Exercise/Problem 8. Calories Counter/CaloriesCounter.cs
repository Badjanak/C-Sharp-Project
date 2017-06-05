using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Calories_Counter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            int numberOfIngredients = int.Parse(Console.ReadLine());            
            int calories = 0;
            int totalCalories = 0;

            for (int i = 1; i <= numberOfIngredients; i++)
            {
                string ingredients = Console.ReadLine().ToLower();
                switch (ingredients)
                {
                    case "cheese":
                        calories = 500;
                        totalCalories += calories;
                        break;
                    case "tomato sauce":
                        calories = 150;
                        totalCalories += calories;
                        break;
                    case "salami":
                        calories = 600;
                        totalCalories += calories;
                        break;
                    case "pepper":
                        calories = 50;
                        totalCalories += calories;
                        break;
                    default:
                        calories = 0;
                        break;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
