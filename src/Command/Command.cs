using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    abstract class Command
    {
        protected Receiver receiver;
        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }
        public abstract void Exec();
    }

    class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }
        public override void Exec()
        {
            receiver.Action();
        }
    }
}
