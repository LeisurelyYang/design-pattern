using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Waiter
    {
        private IList<AbstractCommand> orders = new List<AbstractCommand>();
        public void SetOrder(AbstractCommand command)
        {
            if (command is BakeChickenWingCommond)
            {
                Console.WriteLine("服务员：鸡翅没有了，请点别的烧烤");
            }
            else
            {
                orders.Add(command);
                Console.WriteLine($"增加订单:{command.ToString()} 时间：{DateTime.Now.ToString()}");
            }
        }

        public void CancelOrder(AbstractCommand command)
        {
            orders.Remove(command);
            Console.WriteLine($"取消订单:{command.ToString()} 时间：{DateTime.Now.ToString()}");
        }

        public void Notify()
        {
            foreach (var cmd in orders)
            {
                cmd.ExcuteCommand();
            }
        }
    }
}
