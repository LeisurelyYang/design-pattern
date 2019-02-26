using System;
using System.Collections.Generic;
using System.Text;

namespace StaticFactory
{
    /// <summary>
    /// 减
    /// </summary>
   public class SubtractOperation : Operation
    {
        public override double Calc()
        {
            return Num1 - Num2;
        }
    }
}
