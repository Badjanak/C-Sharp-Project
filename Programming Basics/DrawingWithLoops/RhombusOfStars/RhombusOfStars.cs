using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class RhombusOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int rows = 1; rows <= n; rows++)
            {
                Console.Write(new string (' ', n - rows));
                Console.Write("*");
                for (int addStar = 0; addStar < rows-1; addStar++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int rows = 1; rows <= n - 1; rows++)
            {
                Console.Write(new string(' ', rows));
                Console.Write("*");
                for (int addStar = 0; addStar < n-(rows+1); addStar++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
