using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Command
{
    /// <summary>
    /// 请求者角色
    /// </summary>
    public class Invoker
    {
        Command cmd;

        public Invoker(Command cmd)
        {
            this.cmd = cmd;
        }

        public void ExcuteCommand()
        {
            cmd.Action();
        }
    }
}