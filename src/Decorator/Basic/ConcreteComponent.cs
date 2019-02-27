using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Basic
{
    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("具体对象的操作");
        }
    }
}
