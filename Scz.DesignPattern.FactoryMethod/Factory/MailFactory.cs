using System;
using System.Collections.Generic;
using System.Text;

namespace Scz.DesignPattern.FactoryMethod
{
   public class MailFactory : IFactory
    {
        public ISender Produce()
        {
           return  new MailSender();
        }
    }
}
