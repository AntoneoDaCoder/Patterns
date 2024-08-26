using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
{
    internal class LogisticsCompany
    {
        private Logistics Method;
        public LogisticsCompany(int num)
        {
            switch (num)
            {
                case 0:
                    Method = new AirLogistics();
                    break;
                case 1:
                    Method = new SeaLogistics();
                    break;
                case 2:
                    Method = new RoadLogistics();
                    break;
                case 3:
                    Method = new RailroadLogistics();
                    break;
            }
        }
        public void DeliverPackage()
        {
            Method.CreateCourier();
            Console.WriteLine(Method.Courier.Deliver());
        }
    }
}
