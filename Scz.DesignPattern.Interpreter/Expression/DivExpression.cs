using System;
using System.Collections.Generic;
using System.Text;

namespace Scz.DesignPattern.Interpreter
{
    public class DivExpression : OperatorExpression
    {
        public DivExpression(Expression left, Expression right) : base(left, right)
        {
        }

        public override double Interpret(Context context)
        {
            return this.left.Interpret(context) / this.right.Interpret(context);
        }
    }
}
