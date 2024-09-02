using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class ICCar : ICar
    {
        //concrete implementation
        public int Fuel { get; set; }
        public int FuelConsumption { get; }
        public ICCar(int fuel, int fuelConsumption)
        {
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
        }
        public void Start()
        {
            Console.WriteLine("Internal combustion car is starting up...");
        }
        public void Stop()
        {
            Console.WriteLine("Internal combustion car is shutting down...");
        }
        public void Drive(string to, int left)
        {
            Console.WriteLine($"Driving to {to}, {left} miles left");
        }
        public void Refuel(int amount)
        {
            Console.WriteLine($"Refueling the car with {amount} gallons");
            Fuel += amount;
        }
    }
}
