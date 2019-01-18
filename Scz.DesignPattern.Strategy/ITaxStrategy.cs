using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Strategy
{
    public interface ITaxStrategy
    {
        double CalculateTax(double income);
    }
}