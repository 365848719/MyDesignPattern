using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Iterator
{
    public interface IListCollection
    {
        Iterator GetIterator();
    }
}