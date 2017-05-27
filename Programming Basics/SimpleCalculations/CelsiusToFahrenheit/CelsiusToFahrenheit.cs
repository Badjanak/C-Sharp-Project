using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    class CelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            //Console.Write("Input Celsius C = ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine(Math.Round(fahrenheit, 2));
        }
    }
}
