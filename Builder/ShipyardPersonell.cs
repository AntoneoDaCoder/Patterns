using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //ship building director (determines the sequence of actions for the builder)
    internal class ShipyardPersonell
    {
        public void BuildShip(IShipyard type)
        {
            type.GetBuildState();
            type.MakeShipCore();
            type.InstallControlSystems();
            type.InstallEngines();
            type.MountTurrets();
            type.RestockSupplies();
            type.GetBuildState();
        }
    }
}
