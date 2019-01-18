using System;
using System.Collections.Generic;
using System.Text;

namespace Scz.DesignPattern.Interpreter
{
    /// <summary>
    /// 抽象表达式
    /// </summary>
    public abstract class Expression
    {
        public abstract double Interpret(Context context);
    }
}
