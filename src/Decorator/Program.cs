using System;
using Decorator.Basic;
using System.Text;
using Decorator.Demo2;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //ConcreteComponent c = new ConcreteComponent();
            //ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            //ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            //d1.SetComponent(c);
            //d2.SetComponent(d1);
            //d2.Operation();

            Person person = new Person("小明");

            KuZi kuzi = new KuZi();
            MaJia mj = new MaJia();
            kuzi.Decorate(person);
            mj.Decorate(kuzi);
            mj.Show();
            Console.ReadKey();
        }
    }
}