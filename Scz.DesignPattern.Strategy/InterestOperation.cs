using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Strategy
{
    public class InterestOperation
    {
        ITaxStrategy strategy;
        public InterestOperation(ITaxStrategy strategy)
        {
            this.strategy = strategy;
        }

        public double GetTax(double income)
        {
            return strategy.CalculateTax(income);
        }
    }
}