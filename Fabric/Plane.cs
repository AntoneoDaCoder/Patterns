using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
{
    internal class Plane : ITransport
    {
        public string Deliver()
        {
            return "Plane is delivering your package.";
        }
    }
}
