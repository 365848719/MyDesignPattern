using System;

namespace Scz.DesignPattern.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleDemo s1 = SingleDemo.GetInstance();
            SingleDemo s2 = SingleDemo.GetInstance();

            if (s1.Equals(s2))
            {
                Console.WriteLine("s1 == s2");
            }
            else
            {
                Console.WriteLine("两个对象不等。。。。");
            }

            Console.ReadKey();
        }
    }
}
