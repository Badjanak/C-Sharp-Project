using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Magic_Letter
{
    class MagicLetter
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char magictLetter = char.Parse(Console.ReadLine());

            for (char firstLetter = startLetter; firstLetter <= endLetter; firstLetter++)
            {
                for (char secondLetter = startLetter; secondLetter <= endLetter; secondLetter++)
                {
                    for (char thirthLetter = startLetter; thirthLetter <= endLetter; thirthLetter++)
                    {
                        string digit = firstLetter.ToString() + secondLetter.ToString() + thirthLetter.ToString();
                        //string digit = "" + firstLetter + secondLetter + thirthLetter;
                        if (!digit.Contains(magictLetter))
                        {
                            Console.Write($"{digit} ");
                        }
                    }
                }
            }
        }
    }
}
