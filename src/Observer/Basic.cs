using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Basic
{
    abstract class Subject
    {
        private IList<Observer> observers = new List<Observer>();

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

        private string subjectState;

        public string SubjectState { get => subjectState; set => subjectState = value; }
    }

    class ConcreteSubject : Subject
    {

    }

    abstract class Observer
    {
        public abstract void Update();
    }

    class ConcreteObserver : Observer
    {
        private string name;
        private Subject subject;
        public ConcreteObserver(Subject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }
        public override void Update()
        {
            Console.WriteLine($"观察者{name}的新状态是{subject.SubjectState}");
        }
    }
}
