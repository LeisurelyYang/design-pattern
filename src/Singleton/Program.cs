using System;
using System.Text;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            if (s1 == s2)
            {
                Console.WriteLine("两个对象是相同的实例。");
            }
            Console.ReadKey();
        }
    }

    class Singleton
    {
        private static readonly object objLock = new object();

        private static Singleton singleton = null;

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (singleton == null)
            {

                lock (objLock)
                {
                    if (singleton == null)
                    {
                        return singleton = new Singleton();
                    }
                }
            }

            return singleton;
        }
    }
}