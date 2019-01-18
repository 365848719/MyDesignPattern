using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Command
{
    /// <summary>
    /// 命令角色
    /// </summary>
    public abstract class Command
    {
        protected Receiver r;
        public Command(Receiver r)
        {
            this.r = r;
        }

        public abstract void Action();
    }
}