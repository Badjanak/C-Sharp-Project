using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 15;
            if (minutes > 59)
            {
                hour = hour + 1;
                if (hour > 23)
                {
                    hour = hour - 24;
                }
                minutes = minutes - 60;
            }
            
            Console.WriteLine("{0}:{1:00}", hour, minutes);
        }
    }
}
