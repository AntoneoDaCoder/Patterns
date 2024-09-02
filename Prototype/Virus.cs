using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Virus : ICell
    {
        public int Size { get; } = 1;
        public bool IsDeadly { get; } = true;
        public Virus(int size, bool deadly)
        {
            Size = size;
            IsDeadly = deadly;
        }
        Virus(Virus prototype)
        {
            Size = prototype.Size;
            IsDeadly = prototype.IsDeadly;
        }
        public ICell Clone()
        {
            return new Virus(this);
        }
    }
}
