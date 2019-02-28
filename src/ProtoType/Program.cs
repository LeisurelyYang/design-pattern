using System;
using ProtoType.Basic;

namespace ProtoType
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype1 pa = new ConcretePrototype1("I");
            var pa1 = (Prototype)pa.Clone();
            Console.WriteLine("Hello World!");
            A a = new A("fdf");
        }
    }

    class A : ICloneable
    {
        private string name;
        private int age;
        private B gg;

        public A(string name)
        {
            this.name = name;
            this.age = 10;
        }
        private A()
        {
            this.gg = (B)gg.Clone();
        }
        public object Clone()
        {
            return (object)new A()
            {
                name = "ss",
                age = 1
            };
        }
    }

    public class B : ICloneable
    {
        public string age;

        public object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }

    internal interface ICloneable
    {
        object Clone();
    }
}