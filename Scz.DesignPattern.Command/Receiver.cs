using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Command
{
    /// <summary>
    /// 命令的接受者
    /// </summary>
    public class Receiver
    {
        public void Run() {
            Console.WriteLine("跑1000米。。。。。");
        }
    }
}