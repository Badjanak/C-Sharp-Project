using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Bills
    {
        static void Main(string[] args)
        {
            int numberOfMonts = int.Parse(Console.ReadLine());
            double water = 20;
            double internet = 15;
            double monthlyElectricityBill = 0;
            double sumElectricity = 0;
            double sumOther = 0;
            double other = 0;
            for (int i = 1; i <= numberOfMonts; i++)
            {
                monthlyElectricityBill = double.Parse(Console.ReadLine());
                other = (35 + monthlyElectricityBill) * 1.2;
                sumOther += other;
                sumElectricity += monthlyElectricityBill;                

            }
            Console.WriteLine("Electricity: {0:0.00} lv", sumElectricity);
            Console.WriteLine("Water: {0:0.00} lv", numberOfMonts*20);
            Console.WriteLine("Internet: {0:0.00} lv", numberOfMonts * 15);
            Console.WriteLine("Other: {0:0.00} lv", sumOther);
            double average = (sumElectricity + (numberOfMonts * 20) + (numberOfMonts * 15) + sumOther) / numberOfMonts;
            Console.WriteLine("Average: {0:0.00} lv", average);


        }
    }
}
