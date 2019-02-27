using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Demo2
{
    public class Finery : Person
    {
        private Person person;

        public void Decorate(Person person)
        {
            this.person = person;
        }

        public override void Show()
        {
            if (person != null)
            {
                person.Show();
            }
        }
    }
}
