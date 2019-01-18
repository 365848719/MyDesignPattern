using System;
using System.Collections.Generic;
using System.Text;

namespace Scz.DesignPattern.FactoryMethod
{
   public  interface IFactory
    {
        ISender Produce();
    }
}
