using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    class GreaterNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers:");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Greater number: " + firstNumber);
            }
            else
            {
                Console.WriteLine("Greater number: " + secondNumber);
            }
        }
    }
}
