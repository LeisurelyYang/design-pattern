using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class FinanceCompany : Company
    {
        public FinanceCompany(string name) : base(name)
        {

        }
        public override void Add(Company c)
        {
            Console.WriteLine("cannot use add");
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new String('-', depth)}{name}");
        }

        public override void LineOfDuty()
        {
            Console.WriteLine($"{name} 发工资的");
        }

        public override void Remove(Company c)
        {
            Console.WriteLine("cannot use remove");
        }
    }
}
