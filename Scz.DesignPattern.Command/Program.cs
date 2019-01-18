using System;

namespace Scz.DesignPattern.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver r = new Receiver();
            Command command = new ConcreteCommand(r);

            Invoker invoker = new Invoker(command);
            invoker.ExcuteCommand();

        }
    }
}
