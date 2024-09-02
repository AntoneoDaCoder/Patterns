using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //concrete builder (for battlecruiser)
    internal class XLShipyard : IShipyard
    {
        private Battlecruiser Product;
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
                Console.WriteLine($"Ship fighter amount: {Product.FighterAmount}");
                Console.WriteLine($"Ship main gun: {Product.MainGun}");
            }
            else
                Console.WriteLine("Awaiting ship core build completion...");
            Console.WriteLine("----------------------------------------------------------------");
        }
        public void MakeShipCore()
        {
            Thread.Sleep(3_500);
            Console.WriteLine("Making a new ship...");
            Product = new Battlecruiser();
            Product.ShipClass = "Battlecruiser";
            Product.ShipSize = "XL";
        }
        public void InstallEngines()
        {
            Thread.Sleep(3_500);
            Console.WriteLine("Installing engine systems...");
            Product.Engines = true;
        }
        public void InstallControlSystems()
        {
            Thread.Sleep(3_500);
            Console.WriteLine("Installing the control system...");
            Product.Type = "Artillery platform";
        }
        public void MountTurrets()
        {
            Thread.Sleep(3_500);
            Console.WriteLine("Mounting turrets...");
            Product.TurretAmount = 12;
            Product.MainGun = true;
        }
        public void RestockSupplies()
        {
            Thread.Sleep(3_500);
            Console.WriteLine("Restocking supplies...");
            Product.FighterAmount = 10;
        }
        public Battlecruiser DeliverCompletedShip()
        {
            Thread.Sleep(3_500);
            Console.WriteLine("Delivering the ship...");
            return Product;
        }
    }
}
