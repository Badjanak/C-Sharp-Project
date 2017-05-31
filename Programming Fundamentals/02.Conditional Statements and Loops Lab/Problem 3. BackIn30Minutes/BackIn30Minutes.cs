using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes > 59)
            {
                minutes = minutes - 60;
                //minutes %= 60;
                hours++;
                if (hours > 23)
                {
                    hours -= 24;
                    //hours %= 24;
                }
            }
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
