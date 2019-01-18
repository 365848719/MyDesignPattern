using System;
using System.Collections.Generic;
using System.Text;

namespace Scz.DesignPattern.Flyweight
{
    public class ConcreteFlyweight : Flyweight
    {
        string innerState;

        public ConcreteFlyweight(string innerState)
        {
            this.innerState = innerState;
        }

        public override void Operation(int existState)
        {
            Console.WriteLine($"具体实现类: intrinsicstate {innerState}, extrinsicstate {existState}");
        }
    }
}
