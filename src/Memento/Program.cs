using System;

namespace Memento
{
    /// <summary>
    /// 备忘录模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Originator ori = new Originator();
            ori.State = "On";

            ori.Show();

            Caretaker c = new Caretaker();

            c.Memento = ori.CreateMemento();

            ori.State = "Off";
            ori.Show();

            ori.SetMemento(c.Memento);

            ori.Show();
            Console.ReadKey();
        }
    }
}