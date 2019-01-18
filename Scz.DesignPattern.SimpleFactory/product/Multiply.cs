using System;
using System.Collections.Generic;
using System.Text;

namespace Scz.DesignPattern.SimpleFactory
{
    /// <summary>
    /// 乘法运算
    /// </summary>
    public class Multiply : Operation
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }
}
