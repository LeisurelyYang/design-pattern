using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class TeacherLeiFengFactory : ILeiFengFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new TeacherLeiFeng();
        }
    }
}
