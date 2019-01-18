using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Visitor
{
    public interface IVisitor
    {
        void Visit(Element e);
    }
}