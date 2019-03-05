using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}
