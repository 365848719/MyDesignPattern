using System;
using System.Collections.Generic;
using System.Text;

namespace Scz.DesignPattern.FactoryMethod
{
    class MailSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Mail 发送者。。。。。。");
        }
    }
}
