using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThousandDaysAfterBirth
{
    class ThousandDaysAfterBirth
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            string format = "dd-MM-yyyy";
            CultureInfo culture = CultureInfo.InvariantCulture;

            DateTime birth = DateTime.ParseExact(inputData, format, culture);
            DateTime afterThousandDays = birth.AddDays(999);
            Console.WriteLine(afterThousandDays.ToString(format));
            //Console.WriteLine("{0:dd-MM-yyyy}", afterThousandDays);

        }
    }
}
