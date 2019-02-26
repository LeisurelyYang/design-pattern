using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class CashRebate : CashSuper
    {
        private double moneyRebate;
        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }
        public override double AcceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}
