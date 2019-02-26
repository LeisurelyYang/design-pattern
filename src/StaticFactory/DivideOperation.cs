using System;
using System.Collections.Generic;
using System.Text;

namespace StaticFactory
{
    /// <summary>
    /// 除
    /// </summary>
    public class DivideOperation : Operation
    {
        public override double Calc()
        {
            return Num1 / Num2;
        }
    }
}
