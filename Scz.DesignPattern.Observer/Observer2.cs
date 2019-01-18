using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Observer
{
    public abstract class Observer2
    {
        public Observer2(Subject subject)
        {
            subject.Action += Response;
        }  
             
        public abstract void Response();
    }
}