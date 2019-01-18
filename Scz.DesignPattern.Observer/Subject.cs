using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Observer
{
    public abstract class Subject
    {
        public Action Action;
        public abstract void FireAway();
    }
}