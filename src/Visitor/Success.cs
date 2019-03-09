using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Success : Action
    {
        public override void GetManConclusion(Man concteteElementA)
        {
            Console.WriteLine($"{concteteElementA.ToString()}{ToString()}时，背后多半有一个伟大的女人");
        }

        public override void GetWoManConclusion(Woman concteteElementB)
        {
            Console.WriteLine($"{concteteElementB.ToString()}{ToString()}时，背后多半有一个不成功的男人");
        }

        public override string ToString()
        {
            return "成功";
        }
    }
}
