using System;

namespace FactoryMethod
{
    //工厂方法
    class Program
    {
        static void Main(string[] args)
        {
            ILeiFengFactory factory = new StudentLeiFengFactory();
            LeiFeng leifeng = factory.CreateLeiFeng();
            leifeng.WeiFan();
            Console.ReadKey();
        }
    }
}
