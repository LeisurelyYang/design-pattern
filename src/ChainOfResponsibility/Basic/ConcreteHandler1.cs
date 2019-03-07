using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Basic
{
    class ConcreteHandler1 : Handle
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine($"{this.GetType().Name}处理请求{request}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
