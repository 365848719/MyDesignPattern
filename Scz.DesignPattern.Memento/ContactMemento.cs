using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Memento
{
    public class ContactMemento
    {
        public List<ContactPerson> ContactPersonBack { get; set; }
        public ContactMemento(List<ContactPerson> persons)
        {
            ContactPersonBack = persons;
        }
    }
}