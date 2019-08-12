using System;

namespace Scz.DesignPattern.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplePhone applePhone = new ApplePhone();

            Accessories accessories = new Accessories(applePhone);
            accessories.Print();

            Sticker sticker = new Sticker(applePhone);
            sticker.Print();

            Console.ReadLine();

        }
    }
}
