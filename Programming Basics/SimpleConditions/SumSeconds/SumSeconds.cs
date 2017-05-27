using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            int seconds1 = int.Parse(Console.ReadLine());
            int seconds2 = int.Parse(Console.ReadLine());
            int seconds3 = int.Parse(Console.ReadLine());
            int totalTime = seconds1 + seconds2 + seconds3;
            int totalMinutes = totalTime / 60;
            int totalSeconds = totalTime % 60;
            Console.WriteLine("Total time: {0}:{1:00}", totalMinutes, totalSeconds);
        }
    }
}
