using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapeAndRakia
{
    class GrapeAndRakia
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double kilosPerMeter = double.Parse(Console.ReadLine());
            double trash = double.Parse(Console.ReadLine());

            double quantity = (area * kilosPerMeter) - trash;
            double rakia = quantity * 0.45;
            double grape = quantity * 0.55;

            double litersRakia = rakia / 7.5;
            double incomeRakia = litersRakia * 9.8;
            double incomeGrape = grape * 1.5;

            Console.WriteLine("{0:0.00}", incomeRakia);
            Console.WriteLine("{0:0.00}", incomeGrape);

        }
    }
}
