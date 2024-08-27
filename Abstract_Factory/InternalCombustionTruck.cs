using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class InternalCombustionTruck : ITruck
    {
        public void DeliverCargo()
        {
            Console.WriteLine("Internal combustion truck has succesfully delivered your cargo.");
        }
    }
}
