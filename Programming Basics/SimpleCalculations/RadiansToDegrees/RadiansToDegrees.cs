using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiansToDegrees
{
    class RadiansToDegrees
    {
        static void Main(string[] args)
        {
            Console.Write("Input radians to convert Rad = ");
            double radians = double.Parse(Console.ReadLine());
            double degrees = radians * 180 / Math.PI;
            Console.WriteLine(Math.Round(degrees));
        }
    }
}
