using System;

namespace Scz.DesignPattern.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuilder builder = new Benz();
            Director director = new Director();
            director.Constructor(builder);

            Run();

            Console.Read();
        }

        static void Run()
        {
            Director2 director = new Director2();
            Builder builder = new ConcreteBuilder1();

            Computer computer = director.Construct(builder);
            computer.Show();
        }
    }
}
