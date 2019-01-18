using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Observer
{
    public class Master : Observer2
    {
        public Master(Subject subject):base(subject)
        {

        }

        public override void Response()
        {
            Console.WriteLine("人醒了。。。");
        }
    }
}