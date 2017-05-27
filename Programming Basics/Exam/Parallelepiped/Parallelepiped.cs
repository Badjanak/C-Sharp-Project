using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallelepiped
{
    class Parallelepiped
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("+");
            Console.Write(new string('~', n - 2));
            Console.Write("+");
            Console.WriteLine(new string('.', 2 * n + 1));

            for (int row = 0; row < 2 * n + 1; row++)
            {
                Console.Write("|");
                Console.Write(new string('.', row));
                Console.Write(@"\");
                Console.Write(new string('~', n - 2));
                Console.Write(@"\");
                Console.Write(new string('.', 2 * n - row));
                Console.WriteLine();
            }

            for (int row = 0; row < 2 * n + 1; row++)
            {
                Console.Write(new string('.', row));
                Console.Write(@"\");
                Console.Write(new string('.', 2 * n - row));
                Console.Write("|");
                Console.Write(new string('~', n - 2));
                Console.Write("|");
                Console.WriteLine();
            }


            Console.Write(new string('.', 2 * n + 1));
            Console.Write("+");
            Console.Write(new string ('~', n - 2));
            Console.WriteLine("+");





        }
    }
}
