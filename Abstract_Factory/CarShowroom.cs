using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    //client that utilizes abstract factory
    internal class CarShowroom
    {
        private ICarFactory Supplier;
        private ICar DemoCar;
        private ITruck DemoTruck;
        public CarShowroom(ICarFactory supplier)
        {
            Supplier = supplier;
            Console.WriteLine($"Currently working with {Supplier.GetType()}");
            DemoCar = Supplier.AssembleCar();
            DemoTruck = Supplier.AssembleTruck();
        }
        public void TestCars()
        {
            DemoCar.Start();
            DemoCar.Drive();
            DemoTruck.DeliverCargo();
        }
    }
}
