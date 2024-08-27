using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    //abstract car factory description
    internal interface ICarFactory
    {
        public ICar AssembleCar();
        public ITruck AssembleTruck();
    }
}
