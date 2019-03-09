using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class ObjectStructure
    {
        private IList<Person> elements = new List<Person>();

        public void Attach(Person element)
        {
            elements.Add(element);
        }

        public void Detach(Person element)
        {
            elements.Remove(element);
        }

        public void Display(Action visitor)
        {
            foreach (var item in elements)
            {
                item.Acccept(visitor);
            }
        }
    }
}
