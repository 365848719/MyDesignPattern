using System;
using System.Collections.Generic;
using System.Text;

namespace Scz.DesignPattern.FactoryMethod
{
   public class SmsSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("SMS 发送者。。。。。。");
        }
    }
}
