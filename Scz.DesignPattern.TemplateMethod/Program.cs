using System;

namespace Scz.DesignPattern.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Vegetabel vegetabel = new Spinach();
            vegetabel.Cook();
        }
    }
}
