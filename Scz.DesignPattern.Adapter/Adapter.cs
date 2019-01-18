using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Adapter
{
    /// <summary>
    /// 类的适配器
    /// </summary>
    public class Adapter : Source, ITargetable
    {

        public new void Method1()
        {
            Console.WriteLine("使用父类的方法。。。。。。。");
            base.Method1();
        }

        public void Method2()
        {
            Console.WriteLine("实现了目标接口。。。。。。。");
        }
    }
}