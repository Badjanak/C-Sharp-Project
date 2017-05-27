using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hourglass
{
    class Hourglass
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());

            //First row
            Console.WriteLine(new string('*', 2*n+1));
            //Second row
            Console.WriteLine("." + "*" + new string(' ', (2*n-3)) + "*" + ".");

            //Upper half
            for (int rows = 0; rows < n-2; rows++)
            {              
                                   
                    Console.Write(new string('.', rows + 2));
                    Console.Write("*");
                for (int monkey = (((2 * n) -5)-(2*rows)); monkey >= 1; monkey -= 1)
                {
                    Console.Write("@");
                }
                    Console.Write("*");
                    Console.WriteLine(new string('.', rows + 2));                                                                 
                
            }
            //Middle part
            Console.Write(new string('.', n));
            Console.Write("*");
            Console.WriteLine(new string('.', n));

            //Bottom part
            for (int downRows = 1; downRows <= n - 2; downRows++)
            {
                Console.Write(new string('.', (n - downRows)));
                Console.Write("*");
                Console.Write(new string(' ', downRows - 1));
                Console.Write("@");
                Console.Write(new string(' ', downRows - 1));
                Console.Write("*");
                Console.WriteLine(new string('.', (n - downRows)));
            }

            //Base
            Console.Write("." + "*");
            Console.Write(new string('@', 2*n-3));
            Console.WriteLine("*" + ".");

            //Last row
            Console.WriteLine(new string ('*', 2*n+1));

        }
    }
}
