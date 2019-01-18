using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Strategy
{
    public class PersonTaxStrategy : ITaxStrategy
    {
        public double CalculateTax(double income)
        {
            return income * 0.12;
        }
    }
}