using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class StudentLeiFengFactory : ILeiFengFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new StudentLeiFeng();
        }
    }
}
