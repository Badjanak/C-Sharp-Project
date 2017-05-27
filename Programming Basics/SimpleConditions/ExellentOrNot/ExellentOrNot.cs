using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExellentOrNot
{
    class ExellentOrNot
    {
        static void Main(string[] args)
        {
            float score = float.Parse(Console.ReadLine());
            if (score >= 5.50)
            {
                Console.WriteLine("Exellent !");
            }
            else
            {
                Console.WriteLine("Not exellent .");
            }
        }
    }
}
