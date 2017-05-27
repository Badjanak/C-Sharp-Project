using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNumber
{
    class ControlNumber
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());
            int checkNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentSum = 0;
            int count = 0;
            bool check = false;

            for (int number1 = 1; number1 <= firstNumber; number1++)
            {
                for (int number2 = lastNumber; number2 >= 1; number2--)
                {                    
                    currentSum = 2 * number1 + 3 * number2;
                    sum += currentSum;
                    count++;
                    if (sum >= checkNumber)
                    {
                        check = true;
                        break;
                    }                    
                }
                if (sum >= checkNumber)
                {
                    check = true;
                    break;
                }

            }
            if (check)
            {
                Console.WriteLine("{0} moves", count);
                Console.WriteLine("Score: {0} >= {1}", sum, checkNumber);
                
            }
            else
            {
                Console.WriteLine("{0} moves", count);
            }
            
        }
    }
}
