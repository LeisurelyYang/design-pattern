using System;
using System.Text;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Facade fade = new Facade();

            fade.MethodA();
            fade.MethodB();
            Console.ReadKey();
        }
    }

    class Facade
    {
        SubSystem1 sys1;
        SubSystem2 sys2;
        SubSystem3 sys3;
        public Facade()
        {
            this.sys1 = new SubSystem1();
            this.sys2 = new SubSystem2();
            this.sys3 = new SubSystem3();
        }

        public void MethodA()
        {
            sys1.Method1();
            sys2.Method2();
        }

        public void MethodB()
        {
            sys2.Method2();
            sys3.Method3();
        }
    }

    class SubSystem1
    {
        public void Method1()
        {
            Console.WriteLine("方法1");
        }
    }

    class SubSystem2
    {
        public void Method2()
        {
            Console.WriteLine("方法2");
        }
    }

    class SubSystem3
    {
        public void Method3()
        {
            Console.WriteLine("方法3");
        }
    }
}