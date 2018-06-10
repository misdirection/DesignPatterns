using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class Hello3 : DungieGame
    {
        public Hello3() => Description = " Masterbeef - The final chapter.";
        public override double Price => 69.99d;
    }
}
