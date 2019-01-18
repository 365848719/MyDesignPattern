using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Visitor
{
    public class ConcreteVisitor : IVisitor
    {
        public void Visit(Element e)
        {
            e.Print();
        }
    }
}