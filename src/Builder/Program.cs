using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ConcreteBuild1 c1 = new ConcreteBuild1();
            ConcreteBuild2 c2 = new ConcreteBuild2();

            Director d = new Director();

            d.Contruct(c1);
            c1.GetResult().Show();

            d.Contruct(c2);
            c2.GetResult().Show();

            Console.ReadKey();
        }
    }

    class Director
    {
        public void Contruct(Builder builde)
        {
            builde.BuildA();
            builde.BuildB();
        }
    }

    //建造的产品
    class Product
    {
        IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("建造结果");
            foreach (var item in parts)
            {
                Console.WriteLine(item);
            }
        }
    }

    abstract class Builder
    {
        public abstract void BuildA();

        public abstract void BuildB();

        public abstract Product GetResult();
    }

    class ConcreteBuild1 : Builder
    {
        Product product = new Product();
        public override void BuildA()
        {
            product.Add("瘦子部件A");
        }

        public override void BuildB()
        {
            product.Add("瘦子部件B");
        }

        public override Product GetResult()
        {
            return product;
        }
    }

    class ConcreteBuild2 : Builder
    {
        Product product = new Product();
        public override void BuildA()
        {
            product.Add("胖子部件A");
        }

        public override void BuildB()
        {
            product.Add("胖子部件B");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}