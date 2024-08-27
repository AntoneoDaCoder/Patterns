using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    //concrete factory for concrete product
    internal class HCarFactory : ICarFactory
    {
        public ICar AssembleCar()
        {
            Console.WriteLine("A new hybrid car has been assembled!");
            return new HybridCar();
        }
        public ITruck AssembleTruck()
        {
            Console.WriteLine("A new hybrid truck has been assembled!");
            return new HybridTruck();
        }
    }
}
