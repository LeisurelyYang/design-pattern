using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    abstract class Person
    {
        public abstract void Acccept(Action visitor);
    }
}
