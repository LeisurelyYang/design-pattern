using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class CashNormal : CashSuper
    {
        public override double AcceptCash(double money)
        {
            return money;
        }
    }
}
