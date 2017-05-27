using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCombinations
{
    class LettersCombinations
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char lastLetter = char.Parse(Console.ReadLine());
            char skipLetter = char.Parse(Console.ReadLine());
            int count = 0;

            for (char letter1 = firstLetter; letter1 <= lastLetter; letter1++)
            {
                if (letter1 != skipLetter)
                {
                    for (char letter2 = firstLetter; letter2 <= lastLetter; letter2++)
                    {
                        if (letter2 != skipLetter)
                        {
                            for (char letter3 = firstLetter; letter3 <= lastLetter; letter3++)
                            {

                                if (letter3 != skipLetter)
                                {
                                    string currentOutput = (letter1.ToString() + letter2.ToString() + letter3.ToString());
                                    Console.Write("{0} ", currentOutput);
                                    count++;
                                }

                            }
                        }
                    } 
                }
            }
            Console.WriteLine(count);
        }
    }
}
