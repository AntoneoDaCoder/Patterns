using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    //concrete factory for concrete product
    internal class ECarFactory : ICarFactory
    {
        public ICar AssembleCar()
        {
            Console.WriteLine("A new e-car has been assembled!");
            return new ElectricCar();
        }
        public ITruck AssembleTruck()
        {
            Console.WriteLine("A new e-truck truck has been assembled!");
            return new ElectricTruck();
        }
    }
}
