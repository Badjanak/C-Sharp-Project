using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class BonusPoints
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            double number = double.Parse(Console.ReadLine());
            double bonus = 0;
            double extraBonus = 0;
            if (number <= 100)
            {
                bonus = 5;
            }
            else if (number > 1000)
            {
                bonus = number * 0.1;
            }
            else
            {
                bonus = number * 0.2;
            }
            if (number % 2 == 0)
            {
                extraBonus += 1;
            }
            else if (number % 10 == 5)
            {
                extraBonus += 2;
            }
            Console.WriteLine("Bonus score: " + (bonus + extraBonus));
            Console.WriteLine("Total score: " + (number + bonus + extraBonus));
        }
    }
}
