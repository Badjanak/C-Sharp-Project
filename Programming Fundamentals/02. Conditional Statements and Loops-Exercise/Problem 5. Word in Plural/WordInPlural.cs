using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Word_in_Plural
{
    class WordInPlural
    {
        static void Main(string[] args)
        {
            //Input
            string word = Console.ReadLine();

            //Logic
            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 1);
                word += "ies";
            }
            else if (word.EndsWith("o") ||
                    word.EndsWith("ch") ||
                    word.EndsWith("s") ||
                    word.EndsWith("sh") ||
                    word.EndsWith("x") ||
                    word.EndsWith("z"))
            {
                word += "es";
            }
            else
            {
                word += "s";
            }

            //Output
            Console.WriteLine(word);
        }
    }
}
