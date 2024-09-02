using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    //refined abstraction
    internal class InexperiencedDriver : Driver
    {
        public InexperiencedDriver(ICar vehicle) : base(vehicle)
        {
            Speed = 3;
            RefuelAmount = 20;
        }
    }
}
