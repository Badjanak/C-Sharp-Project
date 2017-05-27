using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number0._._._9ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            //switch (number)
            //{
            //    case 0:
            //        Console.WriteLine("zero");
            //        break;
            //    case 1:
            //        Console.WriteLine("one");
            //        break;
            //    case 2:
            //        Console.WriteLine("two");
            //        break;
            //    case 3:
            //        Console.WriteLine("three");
            //        break;
            //    case 4:
            //        Console.WriteLine("four");
            //        break;
            //    case 5:
            //        Console.WriteLine("five");
            //        break;
            //    case 6:
            //        Console.WriteLine("six");
            //        break;
            //    case 7:
            //        Console.WriteLine("seven");
            //        break;
            //    case 8:
            //        Console.WriteLine("eight");
            //        break;
            //    case 9:
            //        Console.WriteLine("nine");
            //        break;
            //    default:
            //        Console.WriteLine("number too big");
            //        break;
            //}
            if (number == 0)
            {
                Console.WriteLine("zero");
            }
            else if (number == 1)
            {
                Console.WriteLine("one");
            }
            else if (number == 2)
            {
                Console.WriteLine("two");
            }
            else if (number == 3)
            {
                Console.WriteLine("three");
            }
            else if (number == 4)
            {
                Console.WriteLine("four");
            }
            else if (number == 5)
            {
                Console.WriteLine("five");
            }
            else if (number == 6)
            {
                Console.WriteLine("six");
            }
            else if (number == 7)
            {
                Console.WriteLine("seven");
            }
            else if (number == 8)
            {
                Console.WriteLine("eight");
            }
            else if (number == 9)
            {
                Console.WriteLine("nine");
            }
            else
            {
                Console.WriteLine("number too big");
            }
        }
    }
}
