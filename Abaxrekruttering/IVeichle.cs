using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering
{
    internal interface IVeichle
    {
        string Name { get; set; }
        string RegNumber { get; set; }
        int Effect { get; set; }
        public void Move();
        public void PrintInfo();
    }
}
