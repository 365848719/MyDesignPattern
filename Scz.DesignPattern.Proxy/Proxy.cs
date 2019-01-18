using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Proxy
{
    public class Proxy : ISourceable
    {
        Source source;
        public Proxy()
        {
            source = new Source();
        }

        public void Method1()
        {
            Before();
            source.Method1();
            After();
        }


        void Before()
        {
            Console.WriteLine("before proxy !");
        }

         void After()
        {
            Console.WriteLine("after proxy !");
        }
    }
}