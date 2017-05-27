using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моля, въведете първоначалната скорост в километри: ");
            double v0 = double.Parse(Console.ReadLine());
            Console.WriteLine("Моля, въведете първоначалното време в минути: ");
            double t0 = double.Parse(Console.ReadLine());
            Console.WriteLine("Моля, въведете второто време в минути: ");
            double t1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Моля, въведете третото време в минути: ");
            double t2 = double.Parse(Console.ReadLine());
            double S;
            double S0 = v0 * (t0 / 60);
            double v1 = v0 * 1.1;
            double S1 = v1 * (t1 / 60);
            double S2 = (v1 * 0.95) * (t2 / 60);
            S = S0 + S1 + S2;
            Console.WriteLine("Изминатото разстояние е {0:0.00}", S);
        }
    }
}
