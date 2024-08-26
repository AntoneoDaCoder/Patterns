using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
{
    internal class Train : ITransport
    {
        public string Deliver()
        {
            return "Train is delivering your package.";
        }
    }
}
