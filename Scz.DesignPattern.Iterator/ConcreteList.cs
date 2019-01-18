using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Iterator
{
    public class ConcreteList : IListCollection
    {
        int[] collection;

        public ConcreteList()
        {
            collection = new int[] { 2, 4, 8, 10, 98 };
        }

        public int Length
        {
            get { return collection.Length; }
        }

        public object GetElement(int index)
        {
            return collection[index];
        }

        public Iterator GetIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}