using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                int starsInTop = 2;
                int dashesInTopPerSide = (n - starsInTop) / 2;
                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write(new string('-', dashesInTopPerSide));
                    Console.Write(new string('*', starsInTop));
                    Console.WriteLine(new string('-', dashesInTopPerSide));
                    starsInTop += 2;
                    dashesInTopPerSide -= 1;              

                }
                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write("|");
                    Console.Write(new string('*', n-2));
                    Console.WriteLine("|");
                }
            }
            else
            {
                int starsInTop = 1;
                int dashesInTopPerSide = (n - starsInTop) / 2;
                for (int i = 0; i < n / 2 + 1; i++)
                {
                    Console.Write(new string('-', dashesInTopPerSide));
                    Console.Write(new string('*', starsInTop));
                    Console.WriteLine(new string('-', dashesInTopPerSide));
                    starsInTop += 2;
                    dashesInTopPerSide -= 1;

                }
                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write("|");
                    Console.Write(new string('*', n - 2));
                    Console.WriteLine("|");
                }
            }
        }
    }
}
