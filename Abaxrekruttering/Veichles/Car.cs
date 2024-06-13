using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering.Veichles
{
    internal class Car : IVeichle
    {
        public string Name { get; set; }
        public string RegNumber { get; set; }
        public int Effect { get; set; }

        public int MaxSpeed { get; set; }

        public string Color { get; set; }
        public string Weight { get; set; }

        public void Move()
        {
            Console.WriteLine($"You're driving {Name}");
            Thread.Sleep(2000);
            Console.WriteLine($"Thanks for the test drive! I hope you liked it.");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"Registration Number: {RegNumber}");
            Console.WriteLine($"Effect: {Effect}KW");
            Console.WriteLine($"Max speed: {MaxSpeed}KM/h");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine();
        }
        public Car(string regNumber, int effect, int maxSpeed, string color, string weight, string name = "Unknown name")
        {
            Name = name;
            RegNumber = regNumber;
            Effect = effect;
            MaxSpeed = maxSpeed;
            Color = color;
            Weight = weight;
        }
    }
}
