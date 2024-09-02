using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    //abstraction
    internal class Driver
    {
        protected ICar Vehicle;
        public int Speed { get; protected set; } = 5;
        public int RefuelAmount { get; protected set; } = 10;
        public Driver(ICar vehicle)
        {
            Vehicle = vehicle;
        }
        public void Introduce()
        {
            Console.WriteLine($"{GetType()} is your driver today.");
        }
        public void DriveToDestination(string to, int pathLength)
        {
            Vehicle.Start();
            while (pathLength > 0)
            {
                Vehicle.Drive(to, pathLength);
                pathLength -= Speed;
                Vehicle.Fuel -= Vehicle.FuelConsumption;
                if (Vehicle.Fuel < 0)
                {
                    Console.WriteLine("Ran out of fuel.");
                    Vehicle.Refuel(RefuelAmount);
                }
            }
            Vehicle.Stop();
            Console.WriteLine("Arrived at destination.");
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
