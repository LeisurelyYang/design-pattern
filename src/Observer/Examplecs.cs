using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    //通知者接口
    interface Subject
    {
        void Attach(Observer observer);
        void Detach(Observer observer);

        void Notify();

        string SubjectState
        { get; set; }
    }

    /// <summary>
    /// 老板
    /// </summary>
    class Boss : Subject
    {
        private List<Observer> observers = new List<Observer>();
        public string SubjectState { get; set; }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }
    }

    /// <summary>
    /// 老板
    /// </summary>
    class QianTai : Subject
    {
        private List<Observer> observers = new List<Observer>();
        public string SubjectState { get; set; }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }
    }

    //观察者抽象
    abstract class Observer
    {
        protected string name;
        protected Subject sub;
        public Observer(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }
        public abstract void Update();
    }

    class StockObserver : Observer
    {
        public StockObserver(string name, Subject sub) : base(name, sub)
        {

        }
        public override void Update()
        {
            Console.WriteLine("{0}{1}关闭股票行情，继续工作!", sub.SubjectState, name);
        }
    }

    class NBAObserver : Observer
    {
        public NBAObserver(string name, Subject sub) : base(name, sub)
        {

        }
        public override void Update()
        {
            Console.WriteLine("{0}{1}关闭股票行情，继续工作!", sub.SubjectState, name);
        }
    }
}
