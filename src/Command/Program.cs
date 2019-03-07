using System;

namespace Command
{
    /// <summary>
    /// 命令模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Receiver r = new Receiver();
            //Command c = new ConcreteCommand(r);

            //Invoke i = new Invoke();
            //i.SetCommand(c);
            //i.ExecCommand();

            Barbecuer boy = new Barbecuer();

            AbstractCommand bakeMuttonCommand1 = new BakeMuttonCommond(boy);

            AbstractCommand bakeMuttonCommand2 = new BakeMuttonCommond(boy);

            AbstractCommand bakeChickenCommand = new BakeChickenWingCommond(boy);

            Waiter girl = new Waiter();
            girl.SetOrder(bakeMuttonCommand1);
            girl.SetOrder(bakeMuttonCommand2);
            girl.SetOrder(bakeChickenCommand);

            girl.Notify();
            Console.ReadKey();
        }
    }
}
