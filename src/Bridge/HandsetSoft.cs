using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    /// <summary>
    /// 手机软件抽象类
    /// </summary>
    abstract class HandsetSoft
    {
        public abstract void Run();
    }

    class HandsetGame : HandsetSoft
    {
        public override void Run()
        {
            Console.WriteLine("运行手机游戏");
        }
    }

    /// <summary>
    /// 手机通讯录
    /// </summary>
    class HandsetAddressList : HandsetSoft
    {
        public override void Run()
        {
            Console.WriteLine("运行手机通讯录");
        }
    }
}
