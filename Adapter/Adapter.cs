using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Adapter : IClientInterface
    {
        private Service Adaptee;
        public int Num { get; }
        public Adapter(Service adaptee)
        {
            Adaptee = adaptee;
            Num = (int)Adaptee.Num;
        }
        public int Add(IClientInterface client)
        {
            //some conversion from service to client method should be called before returning result, but i've made a bad example
            //conversion happens in constructor instead
            return Num + client.Num;
        }
    }
}
