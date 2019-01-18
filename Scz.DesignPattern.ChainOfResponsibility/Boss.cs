using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scz.DesignPattern.ChainOfResponsibility
{
    public class Boss:Handler
    {
        protected override bool IsInResposibilityScope(float days)
        {
            return days > 3 && days <= 7;
        }

        protected override void Sign()
        {
            Console.WriteLine("老板同意了。。。。");
        }
    }
}
