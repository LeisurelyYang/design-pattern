using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Basic
{
    public class ConcreteDecoratorA : Decorator
    {
        private string addedState;
        public override void Operation()
        {
            base.Operation();
            addedState = "new State";
            Console.WriteLine("具体装饰对象A操作");
        }
    }
}
