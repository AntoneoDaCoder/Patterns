using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    //concrete product
    internal class ElectricCar : ICar
    {
        public void Start()
        {
            Console.WriteLine("beep");
        }
        public void Drive()
        {
            Console.WriteLine("woooooooooooooooooooooosh");
        }
    }
}
