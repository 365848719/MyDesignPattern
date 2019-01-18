using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Proxy
{
    public class Source : ISourceable
    {
        public void Method1()
        {
            Console.WriteLine("执行。。。");
        }
    }
}