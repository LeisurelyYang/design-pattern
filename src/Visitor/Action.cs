using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    abstract class Action
    {
        public abstract void GetManConclusion(Man concteteElementA);

         public abstract void GetWoManConclusion(Woman concteteElementB);
    }
}
