using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Basic
{
    abstract class Handle
    {
        protected Handle successor;

        public void SetSuccessor(Handle successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int request);
    }
}
