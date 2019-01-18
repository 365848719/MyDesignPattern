using System;

namespace Scz.DesignPattern.Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "a+b-c*a+d/a";
            Console.WriteLine(expression);

            Calculator c = new Calculator(expression);
            var value = c.Calculate();

            Console.WriteLine( "得到：" + value);
            Console.ReadLine();
        }
    }
}
