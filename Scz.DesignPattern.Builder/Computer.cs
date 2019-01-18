using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Scz.DesignPattern.Builder
{
    public class Computer
    {
        List<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("开始组装电脑。。。。。。。");
            parts.ForEach(x=> Console.WriteLine("组件"+ x + "已装好！"));

            Console.WriteLine("电脑组装好了。。。。。。。");

        }
    }
}