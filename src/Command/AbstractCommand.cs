using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public abstract class AbstractCommand
    {
        protected Barbecuer receiver;
        public AbstractCommand(Barbecuer receiver)
        {
            this.receiver = receiver;
        }

        abstract public void ExcuteCommand();
    }

    public class BakeMuttonCommond : AbstractCommand
    {
        public BakeMuttonCommond(Barbecuer receiver) : base(receiver)
        {

        }

        public override void ExcuteCommand()
        {
            receiver.BakeMutton();
        }
    }

    public class BakeChickenWingCommond : AbstractCommand
    {
        public BakeChickenWingCommond(Barbecuer receiver) : base(receiver)
        {

        }

        public override void ExcuteCommand()
        {
            receiver.BakeChickenWing();
        }
    }
}
