using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering.Commands
{
    internal class CompareVeichlesCmd : ICommand
    {
        public int Option => 2;
        public string Label => "Compare Veichles";
        public List<IVeichle> _veichles { get; set; }

        public void Execute(List<IVeichle> _allVeichles)
        {
            _veichles = _allVeichles;
        }

        public string GetStringToPrint()
        {
            return $"{Option}.{Label}";
        }
    }
}
