using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Adapter
{
    /// <summary>
    /// 对象的适配器
    /// </summary>
    public class Wrapper : ITargetable
    {
        ISourceable target;

        public Wrapper(ISourceable target)
        {
            this.target = target;
        }

        public void Method1()
        {
            target.Method1();
        }

        public void Method2()
        {
            Console.WriteLine("执行，对象适配器。。。。。。。");
        }
    }
}