using System;

namespace Scz.DesignPattern.Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            MediatorPattern();
        }

        /// <summary>
        /// 中介者模式
        /// </summary>
        public static void MediatorPattern()
        {
            AbstractCardPartner a = new PartnerA();
            AbstractCardPartner b = new PartnerB();

            a.Money = 20;
            b.Money = 20;

            AbstractMediator m = new MediatorPater(a, b);
            a.ChangeMoney(5, m);

            Console.WriteLine("a 现在的钱是：{0}", a.Money);// 应该是25
            Console.WriteLine("b 现在的钱是：{0}", b.Money);// 应该是15

        }

    }
}
