using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    //refined abstraction
    internal class ExperiencedDriver : Driver
    {
        public ExperiencedDriver(ICar vehicle) : base(vehicle)
        {
            Speed = 15;
            RefuelAmount = 30;
        }
    }
}
