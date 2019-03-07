using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class UnitedNationSecurityCouncil : UnitedNations
    {
        public USA Countey1 { private get; set; }

        public Iraq Countey2 { private get; set; }
        public override void Declare(string message, Country country)
        {
            if (country == Countey1)
            {
                Countey2.GetMessage(message);
            }
            else
            {
                Countey1.GetMessage(message);
            }
        }
    }
}
