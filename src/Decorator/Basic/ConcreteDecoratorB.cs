using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Basic
{
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("具体装饰对象B操作");
        }

        private void AddedBehavior()
        {

        }
    }
}
