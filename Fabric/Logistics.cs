using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
{
    //Fabric pattern for all concrete products (air delivery, ground delivery and so on)
    abstract class Logistics
    {
        public ITransport Courier { get; set; }
        public abstract void CreateCourier();
    }
}
