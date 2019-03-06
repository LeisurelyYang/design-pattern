using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class Abstraction
    {
        protected Implmentor implementor;

        public void SetImplementor(Implmentor implementor)
        {
            this.implementor = implementor;
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }

    class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
