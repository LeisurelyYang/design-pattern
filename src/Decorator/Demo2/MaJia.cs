using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Demo2
{
    public class MaJia:Finery
    {
        public override void Show()
        {
            Console.WriteLine("马甲");
            base.Show();
        }
    }
}
