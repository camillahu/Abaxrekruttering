using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering.Veichles
{
    internal class Boat : IVeichle
    {
        public string Name { get; set; }
        public string RegNumber { get; set; }
        public int Effect { get; set; }
        public int MaxSpeedInKn { get; set; }
        public int WeightInTU { get; set; }

        public void Move()
        {
            Console.WriteLine($"You're sailing {Name}");
            Thread.Sleep(2000);
            Console.WriteLine($"Thanks for the test sailing! I hope you liked it.");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"Registration Number: {RegNumber}");
            Console.WriteLine($"Effect: {Effect}KW");
            Console.WriteLine($"Max speed: {MaxSpeedInKn}KN");
            Console.WriteLine($"Tonnage units: {WeightInTU}TU");
            Console.WriteLine();
        }

        public Boat(string regNumber, int effect, int maxSpeedInKn, int weightInTu, string name = "Unknown name")
        {
            Name = name;
            RegNumber = regNumber;
            Effect = effect;
            MaxSpeedInKn = maxSpeedInKn;
            WeightInTU = weightInTu;
        }
    }
}
