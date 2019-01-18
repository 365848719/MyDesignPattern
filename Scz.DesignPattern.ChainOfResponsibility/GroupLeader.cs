using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scz.DesignPattern.ChainOfResponsibility
{
    public class GroupLeader:Handler
    {
        protected override bool IsInResposibilityScope(float days)
        {
            return days <= 1;
        }

        protected override void Sign()
        {
            Console.WriteLine("主管同意了。。。。。");
        }
    }
}
