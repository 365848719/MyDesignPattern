using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Observer
{
    public class Cat : Subject
    {
        public override void FireAway()
        {
            Console.WriteLine("猫叫。。。。。。");
            Action?.Invoke();
        }
    }
}