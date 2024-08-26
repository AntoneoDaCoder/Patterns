using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
{
    internal class RoadLogistics:Logistics
    {
        //fabric method for concrete type of transport
        public override void CreateCourier()
        {
            Courier = new Truck();
        }
    }
}
