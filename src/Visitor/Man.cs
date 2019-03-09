using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Man : Person
    {
        public override void Acccept(Action visitor)
        {
            visitor.GetManConclusion(this);
        }
        public override string ToString()
        {
            return "男人";
        }
    }
}
