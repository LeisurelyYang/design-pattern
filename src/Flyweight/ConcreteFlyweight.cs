using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine($"具体Flyweight:{extrinsicstate}");
        }
    }
}
