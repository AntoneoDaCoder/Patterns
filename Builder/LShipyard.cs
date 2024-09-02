using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //concrete builder (for cruisers)
    internal class LShipyard : IShipyard
    {
        private Cruiser Product;
        public void GetBuildState()
        {
            Console.WriteLine("----------------------------------------------------------------");
            if (Product is not null)
            {
                Console.WriteLine($"Ship size: {Product.ShipSize}");
                Console.WriteLine($"Ship class: {Product.ShipClass}");
                Console.WriteLine($"Ship control system: {Product.Type}");
                Console.WriteLine($"Ship engines: {Product.Engines}");
                Console.WriteLine($"Ship turret amount: {Product.TurretAmount}");
                Console.WriteLine($"Ship flak turret amount: {Product.FlakTurretAmount}");
                Console.WriteLine($"Ship missile bay: {Product.MissileAmount}");
            }
            else
                Console.WriteLine("Awaiting ship core build completion...");
            Console.WriteLine("----------------------------------------------------------------");
        }
        public void MakeShipCore()
        {
            Thread.Sleep(1_500);
            Console.WriteLine("Making a new ship...");
            Product = new Cruiser();
            Product.ShipClass = "Cruiser";
            Product.ShipSize = "L";
        }
        public void InstallEngines()
        {
            Thread.Sleep(1_500);
            Console.WriteLine("Installing engine systems...");
            Product.Engines = true;
        }
        public void InstallControlSystems()
        {
            Thread.Sleep(1_500);
            Console.WriteLine("Installing the control system...");
            Product.Type = "Missile cruiser";
        }
        public void MountTurrets()
        {
            Thread.Sleep(1_500);
            Console.WriteLine("Mounting turrets...");
            Product.TurretAmount = 6;
            Product.FlakTurretAmount = 4;
        }
        public void RestockSupplies()
        {
            Thread.Sleep(1_500);
            Console.WriteLine("Restocking supplies...");
            Product.MissileAmount = 100;
        }
        public Cruiser DeliverCompletedShip()
        {
            Thread.Sleep(1_500);
            Console.WriteLine("Delivering the ship...");
            return Product;
        }
    }
}
