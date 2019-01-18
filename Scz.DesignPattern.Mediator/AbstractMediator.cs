namespace Scz.DesignPattern.Mediator
{
    /// <summary>
    /// 抽象中介类
    /// </summary>
    public abstract class AbstractMediator
    {
        protected AbstractCardPartner partnerA;
        protected AbstractCardPartner partnerB;

        public AbstractMediator(AbstractCardPartner a,AbstractCardPartner b)
        {
            partnerA = a;
            partnerB = b;
        }

        public abstract void Awin(int money);
        public abstract void Bwin(int money);
    }
}