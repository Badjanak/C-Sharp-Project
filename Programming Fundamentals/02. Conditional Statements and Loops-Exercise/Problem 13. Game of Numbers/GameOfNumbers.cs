using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Game_of_Numbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            int countOfCombinations = 0;

            for (int firstNumber = m; firstNumber >= n; firstNumber--)
            {
                for (int secondNumber = m; secondNumber >= n; secondNumber--)
                {
                    countOfCombinations++;

                    if (magicalNumber == firstNumber + secondNumber)
                    {
                        Console.WriteLine($"Number found! {firstNumber} + {secondNumber} = {magicalNumber}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{countOfCombinations} combinations - neither equals {magicalNumber}");
        }
    }
}
