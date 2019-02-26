using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 800;
            CashContext context = new CashContext("正常收费");
            Console.WriteLine(context.GetResult(num));

            CashContext context1 = new CashContext("满300返100");
            Console.WriteLine(context1.GetResult(num));

            CashContext context2 = new CashContext("打8折");
            Console.WriteLine(context2.GetResult(num));
            Console.ReadKey();
        }
    }
}