using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class CheckPrime
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool IsPrime = true;
            if (num < 2)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                for (int i = 2; i <= num - 1; i++)
                {
                    if (num % i == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not Prime");
                }

            }         
            
        }
    }
}
