using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoType.Basic
{
    public abstract class Prototype
    {
        private string id;
        public Prototype(string id)
        {
            this.id = id;
        }

        public abstract Prototype Clone();
    }
}
