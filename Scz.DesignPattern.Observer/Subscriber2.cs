using System;
using System.Collections.Generic;
using System.Text;

namespace Scz.DesignPattern.Observer
{
    public class Subscriber2 : ISubscriber2
    {
        public string Name { get; }
        public Subscriber2(string name)
        {
            this.Name = name;
        }

        public void Execute(TenXun2 tenXun2)
        {
            Console.WriteLine($"通知{this.Name} of {tenXun2.Symbol} 's ,Info is {tenXun2.Info} ");
        }

    }

}
