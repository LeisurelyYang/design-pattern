using System;
using System.Collections.Generic;
using System.Text;

namespace StaticFactory
{
    /// <summary>
    /// 乘
    /// </summary>
    public class MultiplyOperation : Operation
    {
        public override double Calc()
        {
            return Num1 * Num2;
        }
    }
}
