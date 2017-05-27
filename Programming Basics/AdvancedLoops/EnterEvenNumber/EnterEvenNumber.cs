using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class EnterEvenNumber
    {
        static void Main(string[] args)
        {           

            int num;
            while (true)
            {
                try
                {
                    Console.WriteLine("Insert Even Number: ");
                    num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        break;
                    }
                    Console.WriteLine("The number is not EVEN");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");                  
                }
                
            }
            Console.WriteLine("Even number entered: {0}", num);
        }
    }
}
