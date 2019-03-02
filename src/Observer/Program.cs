using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region example1
            //Boss boss = new Boss();

            //StockObserver tongshi1 = new StockObserver("股票的同事", boss);

            //NBAObserver tongshi2 = new NBAObserver("看球赛的同事", boss);

            //boss.Attach(tongshi1);

            //boss.Attach(tongshi2);

            //boss.SubjectState = "我办事回来了，感觉努力工作去";
            //boss.Notify(); 
            #endregion

            Basic.Subject s = new Basic.ConcreteSubject();

            s.Attach(new Basic.ConcreteObserver(s, "X"));
            s.Attach(new Basic.ConcreteObserver(s, "Y"));
            s.Attach(new Basic.ConcreteObserver(s, "Z"));

            s.SubjectState = "ABC";
            s.Notify();
            
            Console.ReadKey();
        }
    }
}
