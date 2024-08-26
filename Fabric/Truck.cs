using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
{
    internal class Truck : ITransport
    {
        public string Deliver()
        {
            return "Truck is delivering your package.";
        }
    }
}
