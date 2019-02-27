using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Demo2
{
    public class KuZi : Finery
    {
        public override void Show()
        {
            Console.WriteLine("裤子");
            base.Show();
        }
    }
}
