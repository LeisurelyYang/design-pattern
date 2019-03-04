using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Caretaker
    {
        private Memento memento;

        public Memento Memento { get => memento; set => memento = value; }
    }
}
