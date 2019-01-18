using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scz.DesignPattern.ChainOfResponsibility
{
    public class Manager : Handler
    {
        protected override bool IsInResposibilityScope(float days)
        {
            return days > 1 && days <= 3;
        }

        protected override void Sign()
        {
            Console.WriteLine("经理同意了。。。。。");
        }
    }
}
