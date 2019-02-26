using System;
using System.Collections.Generic;
using System.Text;

namespace StaticFactory
{
    public class Operation
    {
        private double num1;

        private double num2;

        public double Num1 { get => num1; set => num1 = value; }
        public double Num2 { get => num2; set => num2 = value; }

        public virtual double Calc()
        {
            double result = 0;
            return result;
        }
    }
}
