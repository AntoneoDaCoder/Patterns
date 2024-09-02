using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Cruiser
    {
        public string ShipSize { get; set; }
        public string ShipClass { get; set; }
        public string Type { get; set; }
        public bool Engines { get; set; }
        public int TurretAmount { get; set; }
        public int FlakTurretAmount { get; set; }
        public int MissileAmount { get; set; }
    }
}
