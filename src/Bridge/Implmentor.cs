using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    abstract class Implmentor
    {
        public abstract void Operation();
    }

    class ConcreteImplentorA : Implmentor
    {
        public override void Operation()
        {
            Console.WriteLine("A的实现");
        }
    }

    class ConcreteImplentorB : Implmentor
    {
        public override void Operation()
        {
            Console.WriteLine("B的实现");
        }
    }
}
