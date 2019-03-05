using System;
using System.Text;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "大神";
            a[1] = "小神";
            a[2] = "老神";

            Iterator i = new ConcreteIterator(a);

            object item = i.First();

            while (!i.IsDone())
            {
                Console.WriteLine($"{i.CurrentItem()} 请买车票");
                i.Next();
            }

            Console.ReadKey();
        }
    }
}