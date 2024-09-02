using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Client : IClientInterface
    {
        public int Num { get; }
        public Client(int num)
        {
            Num = num;
        }
        public int Add(IClientInterface client)
        {
            return Num + client.Num;
        }
    }
}
