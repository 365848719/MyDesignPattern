using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Memento
{
    public class MobileOwner
    {
        public List<ContactPerson> ContactPersons { get; set; }
        public MobileOwner(List<ContactPerson> persons)
        {
            ContactPersons = persons;
        }

        public ContactMemento CreateMemento()
        {
            return new ContactMemento(this.ContactPersons);
        }

        public void RestoreMemento(ContactMemento memento)
        {
            if(memento != null)
            {
                this.ContactPersons = memento.ContactPersonBack;
            } 
        }

        public void Show()
        {
            Console.WriteLine("联系人列表中有{0}个人，他们是:", ContactPersons.Count);

            foreach (var p in this.ContactPersons)
            {
                Console.WriteLine("姓名: {0} 号码为: {1}", p.Name, p.MobileNum);
            }
        }
    }
}