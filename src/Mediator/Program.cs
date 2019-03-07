using System;
using System.Text;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            UnitedNationSecurityCouncil UNSC = new UnitedNationSecurityCouncil();

            USA c1 = new USA(UNSC);

            Iraq c2 = new Iraq(UNSC);

            UNSC.Countey1 = c1;

            UNSC.Countey2 = c2;

            c1.Declare("再研制核武器打的萨达姆抬不起头");

            c2.Declare("谁怕谁，生死看淡，不服就干");

            Console.Read();
        }
    }
}