using System;

namespace Scz.DesignPattern.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new SmsFactory();
            ISender sender = factory.Produce();
            sender.Send();

            Console.ReadKey();
        }
    }
}
