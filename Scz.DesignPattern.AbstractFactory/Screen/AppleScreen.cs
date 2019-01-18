using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.AbstractFactory
{
    public class AppleScreen : Screen
    {
        public override void Print()
        {
            Console.WriteLine("this is apple's screen ! ");
        }
    }
}