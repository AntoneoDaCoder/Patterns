using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //since building either a bc or a cruiser requires the same steps we can define them in a builder interface
    internal interface IShipyard
    {
        public void GetBuildState();
        public void MakeShipCore();
        public void InstallEngines();
        public void InstallControlSystems();
        public void MountTurrets();
        public void RestockSupplies();
    }
}
