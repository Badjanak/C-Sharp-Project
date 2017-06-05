using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Triangle_of_Numbers
{
    class TriangleOfNumbers
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());            

            for (int i = 1; i <= rows; i++)
            {
                for (int digit = 1; digit <= i; digit++)
                {
                    Console.Write(i + " ");                    
                }
                Console.WriteLine();            
            }
        }
    }
}
