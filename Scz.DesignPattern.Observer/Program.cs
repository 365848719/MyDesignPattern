using System;

namespace Scz.DesignPattern.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ObserverPattern();
        }

        /// <summary>
        /// 观察者模式
        /// </summary>
        public static void ObserverPattern()
        {
            Console.WriteLine("===============观察者模式=================");

            Method3();

            Method();

            Method2();

        }

        private static void Method3()
        {
            var game2 = new TenXunGame2("TenXun Game", "Have a new game published........");
            var tomSubscriber = new Subscriber2("Tom");
            var liliSubscriber = new Subscriber2("lili");

            game2.AddObserver(tomSubscriber.Execute);
            game2.AddObserver(liliSubscriber.Execute);

            game2.Notify();
            Console.WriteLine();
        }

        private static void Method2()
        {
            TenXunGame game = new TenXunGame("TenXun Game", "Have a new game published ....");
            game.AddObserver(new Subscriber("张三。。。"));
            game.AddObserver(new Subscriber("李四。。。"));

            game.Update();
        }

        private static void Method()
        {
            var cat = new Cat();
            var mouse = new Mouse(cat);
            var master = new Master(cat);
            cat.FireAway();

            cat.Action -= master.Response;
            cat.Action -= mouse.Response;
            cat.FireAway();

            Console.WriteLine();
        }
    }
}
