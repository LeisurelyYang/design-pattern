using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class CashContext
    {
        private CashSuper cs;
        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    cs = new CashNormal();
                    break;
                case "满300返100":
                    cs = new CashReturn("300", "100");
                    break;
                case "打8折":
                    cs = new CashRebate("0.8");
                    break;
                default:
                    break;
            }
        }

        public double GetResult(double money)
        {
            return cs.AcceptCash(money);
        }
    }
}
