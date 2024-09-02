using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    //concrete implementation
    internal class ElectricCar : ICar
    {
        public int Fuel { get; set; }
        public int FuelConsumption { get; }
        public ElectricCar(int fuel, int fuelConsumption)
        {
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
        }
        public void Start()
        {
            Console.WriteLine("Electric car is starting up...");
        }
        public void Stop()
        {
            Console.WriteLine("Electric car is shutting down...");
        }
        public void Drive(string to, int left)
        {
            Console.WriteLine($"Driving to {to}, {left} miles left");
        }
        public void Refuel(int percentage)
        {
            Console.WriteLine($"Charging the car to {percentage}%");
            Fuel += percentage;
        }
    }
}
