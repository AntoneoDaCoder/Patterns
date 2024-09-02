using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal interface IClientInterface
    {
        public int Num { get; }
        public int Add(IClientInterface client);
    }
}
