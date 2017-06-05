using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            //Input
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            //Declaring variables
            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;

            //Logic
            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    doublePrice = 65;
                    suitePrice = 75;
                    if (days > 7 )
                    {
                        studioPrice = studioPrice * 0.95;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 60;
                    doublePrice = 72;
                    suitePrice = 82;
                    if (days > 14)
                    {
                        doublePrice = doublePrice * 0.9;
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    studioPrice = 68;
                    doublePrice = 77;
                    suitePrice = 89;
                    if (days > 14)
                    {
                        suitePrice = suitePrice * 0.85;
                    }
                    break;
            }
            double totalStudioPrice = studioPrice * days;
            double totalDoublePrice = doublePrice * days;
            double totalSuitePrice = suitePrice * days;
            if ((month == "September" || month == "October") & days > 7)
            {
                totalStudioPrice = studioPrice * (days - 1);
            }

            //Output
            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:f2} lv.");
            Console.WriteLine($"Suite: {totalSuitePrice:f2} lv.");
        }
    }
}
