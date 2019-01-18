using System;
using System.Collections.Generic;
using System.Text;

namespace Scz.DesignPattern.DelegationMode
{
    /// <summary>
    /// 委派模式
    /// </summary>
    public interface IExcuter
    {
        void Exec(string command);
    }
}
