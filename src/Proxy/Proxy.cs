using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class Proxy : Subject
    {
        RealSubject real = null;
        public override void Study()
        {
            if (real == null)
            {
                real = new RealSubject();
            }
            Console.WriteLine("我是待你学习");
            real.Study();
        }
    }
}
