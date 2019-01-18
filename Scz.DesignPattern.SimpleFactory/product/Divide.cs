using System;
using System.Collections.Generic;
using System.Text;

namespace Scz.DesignPattern.SimpleFactory
{
    /// <summary>
    /// 除法运算
    /// </summary>
    public class Divide : Operation
    {
        public override double GetResult()
        {
            return NumberA / NumberB;
        }
    }
}
