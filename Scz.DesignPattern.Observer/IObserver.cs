using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Observer
{
    public interface IObserver
    {
        void ReceiveAndPrint(TenXun tenXun);
    }
}