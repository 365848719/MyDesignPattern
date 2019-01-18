using System;
using System.Collections.Generic;
using System.Text;

namespace Scz.DesignPattern.SimpleFactory
{
    /// <summary>
    /// 减法运算
    /// </summary>
    public class Minus : Operation
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }
}
