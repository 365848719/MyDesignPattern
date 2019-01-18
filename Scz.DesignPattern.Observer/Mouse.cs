using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Observer
{
    public class Mouse : Observer2
    {
        public Mouse(Subject s) : base(s)
        {

        }

        public override void Response()
        {
            Console.WriteLine("老鼠跑了。。。。。");
        }
    }
}