using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering.Veichles
{
    internal class Plane : IVeichle
    {
        public string Name { get; set; }
        public string RegNumber { get; set; }
        public int Effect { get; set; }
        public int WingSpanInM { get; set; }
        public int CapacityInT { get; set; }
        public int WeightInT { get; set; }
        public string PlaneClass { get; set; } 
        public void Move()
        {
            Console.WriteLine($"You're flying the {Name}");
            Thread.Sleep(2000);
            Console.WriteLine($"Thanks for the test flight! I hope you liked it.");
        }

        public void PrintInfo()
        {
            Console.WriteLine($" {Name}");
            Console.WriteLine($"Registration Number: {RegNumber}");
            Console.WriteLine($"Effect: {Effect}KW");
            Console.WriteLine($"Wing span: {WingSpanInM}M");
            Console.WriteLine($"Capacity: {CapacityInT}T");
            Console.WriteLine($"Weight: {WeightInT}T");
            Console.WriteLine($"Plane class: {PlaneClass}");
            Console.WriteLine();
        }

        public Plane(string regNumber, int effect, int wingSpanInM, int capacityInT, int weightInT, string planeClass, string name = "Unknown name")
        {
            Name = name;
            RegNumber = regNumber;
            Effect = effect;
            WingSpanInM = wingSpanInM;
            CapacityInT = capacityInT;
            WeightInT = weightInT;
            PlaneClass = planeClass;
        }
    }
}
