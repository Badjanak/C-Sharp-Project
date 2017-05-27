using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups
{
    class Cups
    {
        static void Main(string[] args)
        {
            int planCups = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            //Calculating cups amount

            double cups = Math.Floor((workers * workDays * 8) / 5.0);

            //Prepare to print

            double result = cups - planCups;
            double profit = Math.Abs(result * 4.2);
            if (result > 0)
            {
                
                Console.WriteLine("{0:f2} extra money", profit);
            }
            else
            {
                Console.WriteLine("Losses: {0:f2}", profit);
            }
        }
    }
}
