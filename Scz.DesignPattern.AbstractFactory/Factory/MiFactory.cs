using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.AbstractFactory
{
    public class MiFactory : AbstractFactory
    {
        public override Board CreateMotherBoard()
        {
            throw new NotImplementedException();
        }

        public override Screen CreateScreen()
        {
            throw new NotImplementedException();
        }
    }
}