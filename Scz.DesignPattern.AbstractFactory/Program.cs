using System;

namespace Scz.DesignPattern.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = new AppleFactory();
            Screen screen = factory.CreateScreen();
            screen.Print();

            Board board = factory.CreateMotherBoard();
            board.Print();

            Console.ReadKey();

        }
    }
}
