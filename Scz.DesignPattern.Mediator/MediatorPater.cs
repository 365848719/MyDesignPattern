using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Mediator
{
    /// <summary>
    /// 具体中介类
    /// </summary>
    public class MediatorPater : AbstractMediator
    {
        public MediatorPater(AbstractCardPartner a, AbstractCardPartner b) : base(a, b)
        {

        }

        public override void Awin(int money)
        {
            partnerA.Money += money;
            partnerB.Money -= money;
        }

        public override void Bwin(int money)
        {
            partnerA.Money -= money;
            partnerB.Money += money;
        }

    }
}