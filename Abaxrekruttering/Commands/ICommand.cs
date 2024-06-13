using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering.Commands
{
    internal interface ICommand
    {
        int Option { get; }
        string Label { get; }
        List<IVeichle> _veichles { get; }
        void Execute(List<IVeichle> _allVeichles);

        string GetStringToPrint();
    }
}
