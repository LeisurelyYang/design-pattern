using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class CashReturn : CashSuper
    {
        private double moneyCondition;
        private double moneyReturn;
        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }
        public override double AcceptCash(double money)
        {
            return money - Math.Floor((money / moneyCondition)) * moneyReturn;
        }
    }
}
