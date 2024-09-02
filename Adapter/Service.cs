using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Service
    {
        public char Num { get; }
        public Service(char c)
        {
            Num = c;
        }
    }
}
