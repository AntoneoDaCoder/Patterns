using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    //concrete product
    internal class InternalCombustionCar : ICar
    {
        public void Start()
        {
            Console.WriteLine("dr dr dr brrrrrrrrr");
        }
        public void Drive()
        {
            Console.WriteLine("wrooom wroooooooooooooom wroooooooom");
        }
    }
}
