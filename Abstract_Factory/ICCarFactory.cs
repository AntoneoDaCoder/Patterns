using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    //concrete factory for concrete product
    internal class ICCarFactory : ICarFactory
    {
        public ICar AssembleCar()
        {
            Console.WriteLine("A new internal combustion car has been assembled!");
            return new InternalCombustionCar();
        }
        public ITruck AssembleTruck()
        {
            Console.WriteLine("A new internal combustion truck has been assembled!");
            return new InternalCombustionTruck();
        }
    }
}
