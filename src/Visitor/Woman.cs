using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Woman : Person
    {
        public override void Acccept(Action visitor)
        {
            visitor.GetWoManConclusion(this);
        }

        public override string ToString()
        {
            return "女人";
        }
    }
}
