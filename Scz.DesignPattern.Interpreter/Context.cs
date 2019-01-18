using System;
using System.Collections.Generic;
using System.Text;

namespace Scz.DesignPattern.Interpreter
{
    /// <summary>
    /// 环境
    /// </summary>
    public class Context
    {
        private Dictionary<char, double> variable;
        public Dictionary<char, double> Variable
        {
            get
            {
                if (this.variable == null)
                {
                    this.variable = new Dictionary<char, double>();
                }
                return this.variable;
            }
        }
    }
}
