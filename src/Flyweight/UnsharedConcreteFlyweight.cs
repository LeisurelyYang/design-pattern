using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine($"不共享的Flyweight:{extrinsicstate}");
        }
    }
}
