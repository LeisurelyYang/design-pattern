using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// 职责链模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region BasicDemo
            //Basic.Handle h1 = new Basic.ConcreteHandler1();
            //Basic.Handle h2 = new Basic.ConcreteHandler2();
            //Basic.Handle h3 = new Basic.ConcreteHandler3();

            ////加入写自己的话就会被递归调用，出现死循环
            //h1.SetSuccessor(h2);
            //h2.SetSuccessor(h3);

            //int[] request = { 2, 13, 24, 2, 123, 24, 58, 90 };

            //foreach (var item in request)
            //{
            //    h1.HandleRequest(item);
            //} 
            #endregion

            CommonManager jinli = new CommonManager("经理");
            Majordomo zongjian = new Majordomo("总监");
            GenerManager zhongjingli = new GenerManager("总经理");

            jinli.SetSuperior(zongjian);
            zongjian.SetSuperior(zhongjingli);

            Request request = new Request() {
                RequestType="请假",
                Number=1,
                RequestContent="张三请假"
            };
            jinli.RequestApplication(request);

            Request request1 = new Request()
            {
                RequestType = "请假",
                Number = 4,
                RequestContent = "李斯请假"
            };
            jinli.RequestApplication(request1);
            Request request2 = new Request()
            {
                RequestType = "加薪",
                Number = 500,
                RequestContent = "张三加薪"
            };
            jinli.RequestApplication(request2);
            Request request3 = new Request()
            {
                RequestType = "加薪",
                Number = 10000,
                RequestContent = "李斯加薪"
            };
            jinli.RequestApplication(request3);
            Console.ReadKey();
        }
    }
}
