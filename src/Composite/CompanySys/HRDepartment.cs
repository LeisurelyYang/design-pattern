using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class HRDepartment : Company
    {
        public HRDepartment(string name) : base(name)
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
            Console.WriteLine($"{name} 员工招聘培训管理");
        }

        public override void Remove(Company c)
        {
            Console.WriteLine("cannot use remove");
        }
    }
}
