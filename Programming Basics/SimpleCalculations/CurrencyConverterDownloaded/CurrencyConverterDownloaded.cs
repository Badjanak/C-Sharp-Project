using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var USD = 1.79549;
            var EUR = 1.95583;
            var GBP = 2.53405;
            var money = double.Parse(Console.ReadLine());
            var currencyFrom = Console.ReadLine().ToUpper();
            var currencyTo = Console.ReadLine().ToUpper();
            //currencyFrom = money * currencyTo(Bgn) / currencyFrom(BGN);
            if (currencyFrom == "BGN")
            {
                if (currencyTo == "USD") Console.WriteLine(Math.Round(money / USD, 2) + " USD");
                else if (currencyTo == "EUR") Console.WriteLine(Math.Round(money / EUR, 2) + " EUR");
                else Console.WriteLine(Math.Round(money / GBP, 2) + " GBP");
            }
            else if (currencyFrom == "USD")
            {
                if (currencyTo == "GBP") Console.WriteLine(Math.Round(money * USD / GBP, 2) + " GBP");
                else if (currencyTo == "EUR") Console.WriteLine(Math.Round(money * USD / EUR, 2) + " EUR");
                else Console.WriteLine(Math.Round(money * USD, 2) + " BGN");
            }
            else if (currencyFrom == "EUR")
            {
                if (currencyTo == "GBP") Console.WriteLine(Math.Round(money * EUR / GBP, 2) + " GBP");
                else if (currencyTo == "USD") Console.WriteLine(Math.Round(money * EUR / USD, 2) + " USD");
                else Console.WriteLine(Math.Round(money * EUR, 2) + " BGN");
            }
            else
            {
                if (currencyTo == "EUR") Console.WriteLine(Math.Round(money * GBP / EUR, 2) + " EUR");
                else if (currencyTo == "USD") Console.WriteLine(Math.Round(money * GBP / USD, 2) + " USD");
                else Console.WriteLine(Math.Round(money * GBP, 2) + " BGN");
            }

        }
    }
}