using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            //Input
            double miles = double.Parse(Console.ReadLine());

            //Calculating
            double kilometers = miles * 1.60934;

            //Printing
            Console.WriteLine($"{kilometers:f2}");            
        }
    }
}
