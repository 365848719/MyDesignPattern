using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Command
{
    /// <summary>
    /// 具体的命令角色
    /// </summary>
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver r) : base(r)
        {
        }
        public override void Action()
        {
            this.r.Run();
        }
    }
}