using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public abstract class DungieGame
    {
        public virtual string Description { get; set; }
        public abstract double Price { get; }
    }
}
