using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            //Input data
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            //Calculation
            int healthLoss = maximumHealth - currentHealth;
            int energyLoss = maximumEnergy - currentEnergy;

            //Printing
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Health: " + "|" + new string('|', currentHealth) + new string('.', healthLoss) + "|");
            Console.WriteLine("Energy: " + "|" + new string('|', currentEnergy) + new string('.', energyLoss) + "|");
        }
    }
}
