using System;
using System.Collections.Generic;
using System.Text;

namespace Scz.DesignPattern.DelegationMode
{
    public class Leader : IExcuter
    {
        private Dictionary<string, IExcuter> dic = new Dictionary<string, IExcuter>();

        public Leader()
        {
            dic.Add("加密", new ExcuterA());
            dic.Add("登录", new ExcuterB());
        }

        public void Exec(string command)
        {
            dic.GetValueOrDefault(command).Exec(command);
        }
    }
}
