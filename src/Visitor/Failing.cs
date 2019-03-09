using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Failing : Action
    {
        public override void GetManConclusion(Man concteteElementA)
        {
            Console.WriteLine($"{concteteElementA.ToString()}{ToString()}时，借酒浇愁");
        }

        public override void GetWoManConclusion(Woman concteteElementB)
        {
            Console.WriteLine($"{concteteElementB.ToString()}{ToString()}时，开心的受不了");
        }

        public override string ToString()
        {
            return "失败";
        }
    }
}
