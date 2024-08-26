using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
{
    //base interface for all kinds of delivery methods (by air, ground, underground and so on)
    internal interface ITransport
    {
        public string Deliver();
    }
}
