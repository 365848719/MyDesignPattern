using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Mediator
{
    /// <summary>
    /// 抽象同事类
    /// </summary>
    public abstract class AbstractCardPartner
    {
        public int Money
        {
            get;
            set;
        }

        public abstract void ChangeMoney(int money, AbstractMediator mediator);

    }
}