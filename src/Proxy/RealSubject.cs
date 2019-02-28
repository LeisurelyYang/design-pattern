using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class RealSubject : Subject
    {
        public override void Study()
        {
            Console.WriteLine("真正的学习者");
        }
    }
}
