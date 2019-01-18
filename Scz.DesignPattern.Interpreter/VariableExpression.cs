using System;
using System.Collections.Generic;
using System.Text;

namespace Scz.DesignPattern.Interpreter
{
    /// <summary>
    /// 终结符表达式
    /// </summary>
    class VariableExpression : Expression
    {
        private char key;

        public VariableExpression(char key)
        {
            this.key = key;
        }

        public override double Interpret(Context context)
        {
            return context.Variable.GetValueOrDefault(this.key);
        }
    }
}
