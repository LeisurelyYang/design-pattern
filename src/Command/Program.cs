using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver r = new Receiver();
            Command c = new ConcreteCommand(r);

            Invoke i = new Invoke();
            i.SetCommand(c);
            i.ExecCommand();
            Console.ReadKey();
        }
    }
}
