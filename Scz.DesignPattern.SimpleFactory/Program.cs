using System;

namespace Scz.DesignPattern.SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = OperationFactory.CreateOperate("+");
            operation.NumberA = 10;
            operation.NumberB = 5;

            Console.WriteLine(operation.GetResult());
            Console.Read();

        }
    }
}
