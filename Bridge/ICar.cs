using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    //implementation
    internal interface ICar
    {
        public int Fuel { get; set; }
        public int FuelConsumption { get; }
        public void Start();
        public void Stop();
        public void Drive(string to, int left);
        public void Refuel(int percentage);
    }
}
