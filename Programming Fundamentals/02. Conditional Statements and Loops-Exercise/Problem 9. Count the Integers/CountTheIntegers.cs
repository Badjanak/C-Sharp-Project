using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Count_the_Integers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            int counter = 0;
            try
            {
                while (true)
                {
                    int number = int.Parse(Console.ReadLine());
                    counter++;
                }
            }
            catch (SystemException)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
