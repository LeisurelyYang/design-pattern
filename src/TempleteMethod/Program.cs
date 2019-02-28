using System;

namespace TempleteMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass A = new ConcreteClassA();
            AbstractClass B = new ConcreteClassB();

            A.TempleteMethod();
            B.TempleteMethod();

            Console.ReadKey();
        }
    }

    abstract class AbstractClass
    {
        public abstract void A();
        public abstract void B();

        public void TempleteMethod()
        {
            A();
            B();
            Console.WriteLine("模板方法内");
        }
    }

    class ConcreteClassA : AbstractClass
    {
        public override void A()
        {
            Console.WriteLine("AA");
        }

        public override void B()
        {
            Console.WriteLine("BB");
        }
    }

    class ConcreteClassB : AbstractClass
    {
        public override void A()
        {
            Console.WriteLine("BA");
        }

        public override void B()
        {
            Console.WriteLine("BB");
        }
    }
}