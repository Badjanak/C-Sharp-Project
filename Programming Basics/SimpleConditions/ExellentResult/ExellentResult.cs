using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = double.Parse(Console.ReadLine());
            //bool isItExellent = (score >= 5.50);
            //if (isItExellent)
            if (score >= 5.50)
            {
                Console.WriteLine("Exellent !");
            }
        }
    }
}
