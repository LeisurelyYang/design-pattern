using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    abstract class Manager
    {
        protected string name;

        protected Manager superior;

        public Manager(string name)
        {
            this.name = name;
        }

        public void SetSuperior(Manager superior)
        {
            this.superior = superior;
        }

        abstract public void RequestApplication(Request request);
    }

    class CommonManager : Manager
    {
        public CommonManager(string name) : base(name)
        {

        }
        public override void RequestApplication(Request request)
        {
            if (request.RequestType == "请假" && request.Number <= 2)
            {
                Console.WriteLine($"{name}:{request.RequestContent}数量{request.Number}被批准");
            }
            else
            {
                if (superior != null)
                {
                    superior.RequestApplication(request);
                }
            }
        }
    }

    class Majordomo : Manager
    {
        public Majordomo(string name) : base(name)
        {

        }
        public override void RequestApplication(Request request)
        {
            if (request.RequestType == "请假" && request.Number <= 5)
            {
                Console.WriteLine($"{name}:{request.RequestContent}数量{request.Number}被批准");
            }
            else
            {
                if (superior != null)
                {
                    superior.RequestApplication(request);
                }
            }
        }
    }

    class GenerManager : Manager
    {
        public GenerManager(string name) : base(name)
        {

        }
        public override void RequestApplication(Request request)
        {
            if (request.RequestType == "请假")
            {
                Console.WriteLine($"{name}:{request.RequestContent}数量{request.Number}被批准");
            }
            else if (request.RequestType == "加薪" && request.Number <= 500)
            {
                Console.WriteLine($"{name}:{request.RequestContent}数量{request.Number}被批准");
            }
            else if (request.RequestType == "加薪" && request.Number > 500)
            {
                Console.WriteLine($"{name}:{request.RequestContent}数量{request.Number}再说吧");
            }
        }
    }
}
