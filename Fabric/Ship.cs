using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
{
    internal class Ship : ITransport
    {
        public string Deliver()
        {
            return "Ship is delivering your package.";
        }
    }
}
