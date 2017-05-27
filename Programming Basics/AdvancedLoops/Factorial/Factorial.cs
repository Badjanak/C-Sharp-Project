using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            int counter = 1;
            while (counter <= n)
            {                
                fact = fact * counter;
                counter++;
            }
            Console.WriteLine(fact);
        }
    }
}
