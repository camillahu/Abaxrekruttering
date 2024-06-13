using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering.Commands
{
    internal class GoForASpinCmd : ICommand
    {
        public int Option => 1;
        public string Label => "Test a veichle";
        public List<IVeichle> _veichles { get; set; }

        private bool isChoosingOption = true;
        public void Execute(List<IVeichle>_allVeichles)
        {
            _veichles = _allVeichles;
            ChooseVeichle();
        }
        public void ChooseVeichle()
        {
            Console.WriteLine("Here is some info on all veichles.");
            DrawList();
        }
        public void DrawList()
        {
            for (var i = 0; i < _veichles.Count; i++)
            {
                var type = _veichles[i].GetType();
                Console.WriteLine(i + 1 + "." + type.Name);

                _veichles[i].PrintInfo();
            }
        }

        public void GetVeichleInput()
        {
            string text = "Choose one you want to take for a spin!";
            while (isChoosingOption)
            {
                int chosenOption = text.RequestInt();
                CheckVeichleInput(chosenOption);
            }
        }
        public void CheckVeichleInput(int input)
        {
            if (input > 0 && input <= _veichles.Count)
            {
                isChoosingOption = false;
                _veichles[input - 1].Move();
            }
            else Console.WriteLine("Invalid input, please try again");
        }

        public string GetStringToPrint()
        {
            return $"{Option}.{Label}";
        }
    }
}
