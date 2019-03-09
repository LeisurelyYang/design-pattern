using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Amativeness : Action
    {
        public override void GetManConclusion(Man concteteElementA)
        {
            Console.WriteLine($"{concteteElementA.ToString()}{ToString()}时，花言巧语");
        }

        public override void GetWoManConclusion(Woman concteteElementB)
        {
            Console.WriteLine($"{concteteElementB.ToString()}{ToString()}时，是一个傻子");
        }

        public override string ToString()
        {
            return "恋爱";
        }
    }
}
