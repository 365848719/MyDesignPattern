using System;
using System.Collections.Generic;
using System.Text;

namespace Scz.DesignPattern.FactoryMethod
{
    class SmsFactory : IFactory
    {
        public ISender Produce()
        {
            return new SmsSender();
        }
    }
}
