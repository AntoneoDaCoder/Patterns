using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Bacterium : ICell
    {
        public int Size { get; } = 3;
        public bool IsDeadly { get; } = false;
        public Bacterium(int size, bool deadly)
        {
            Size = size;
            IsDeadly = deadly;
        }
        Bacterium(Bacterium prototype)
        {
            Size = prototype.Size;
            IsDeadly = prototype.IsDeadly;
        }
        public ICell Clone()
        {
            return new Bacterium(this);
        }
    }
}
