using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class HybridTruck : ITruck
    {
        public void DeliverCargo()
        {
            Console.WriteLine("Hybrid truck has succesfully delivered your cargo.");
        }
    }
}
