using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.IntroAndBasicSyntaxExercises
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            //Input data
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirthNumber = int.Parse(Console.ReadLine());
            int forthNumber = int.Parse(Console.ReadLine());

            //Printing
            Console.Write($"{firstNumber:d4} ");
            Console.Write($"{secondNumber:d4} ");
            Console.Write($"{thirthNumber:d4} ");
            Console.WriteLine($"{forthNumber:d4} ");
        }
    }
}
