using System;
using System.Collections.Generic;
using System.Text;

namespace StaticFactory
{
    /// <summary>
    /// 加
    /// </summary>
    public class AddOperation : Operation
    {
        public override double Calc()
        {
            return Num1 + Num2;
        }
    }
}
