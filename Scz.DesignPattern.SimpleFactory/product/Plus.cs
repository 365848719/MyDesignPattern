using System;
using System.Collections.Generic;
using System.Text;

namespace Scz.DesignPattern.SimpleFactory
{
    /// <summary>
    /// 加法运算
    /// </summary>
    public class Plus : Operation
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }

}
