using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class ElectricTruck : ITruck
    {
        public void DeliverCargo()
        {
            Console.WriteLine("Electric truck has succesfully delivered your cargo.");
        }
    }
}
