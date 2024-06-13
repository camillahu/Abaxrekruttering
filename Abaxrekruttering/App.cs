using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Abaxrekruttering.Commands;
using Abaxrekruttering.Veichles;

namespace Abaxrekruttering
{
    internal class App
    {
        private int _chosenOption;
        private bool _isChoosingOption = true;

        private List<IVeichle> _allVeichles =
        [
            new Car("NF123456", 147, 200, "Green", "Light", "Car 1"),
            new Car("NF654321", 150, 195, "Blue", "Light", "Car 2"),

            new Plane("LN1234", 1000, 30, 2, 10, "Jet Plane"),

            new Boat("ABC123", 100, 30, 500)
        ];

        private readonly List<ICommand> _commands =
        [
            new GoForASpinCmd(),
            new CompareVeichlesCmd()
        ];

        public void Run()
        {
           MainMenu();
           GetMenuInput();
            ICommand cmd = FindCommand(_chosenOption);
            cmd.Execute(_allVeichles);
        }

        public void MainMenu()
        {
            foreach (var cmd in _commands)
            {
                Console.WriteLine(cmd.GetStringToPrint());
            }
        }

        private ICommand FindCommand(int input)
        {
            var cmd= _commands.FirstOrDefault(c => c.Option == input);
            return cmd;
        }

        private void GetMenuInput()
        {
           string _text = "Choose an option";
            while (_isChoosingOption)
            {
                _chosenOption = _text.RequestInt();
                CheckMenuInput(_chosenOption);
            }
        }

        public void CheckMenuInput(int input)
        {
            if (input > 0 && input <= _commands.Count)
            {
                _isChoosingOption = false;
            }
            else Console.WriteLine("Invalid input, please try again");
        }


        //Sammenlikne de to bilene over for å sjekke om de er det samme kjøretøyet
        //Endre CheckInput sånn at den sjekker inputen i UI, gjerne med TryParse i stedet for.
        //Ha logikk for når "Unknown name" blir printa
        //Lage en loop slik at man kommer tilbake til main menu når man har gjort noe.
       
    }
}
