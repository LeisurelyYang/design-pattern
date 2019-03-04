using System;

namespace Adapter
{
    /// <summary>
    /// 适配器模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Player b = new Forwards("巴蒂尔");
            b.Attack();

            Player m = new Guards("陈佩斯");
            m.Attack();

            Player ym = new Translator("姚明");
            ym.Attack();
            ym.Defense();
            Console.ReadKey();
        }
    }
}
