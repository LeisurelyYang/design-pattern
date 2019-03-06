using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class Invoke
    {
        private Command command;
        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void ExecCommand()
        {
            command.Exec();
        }
    }
}
