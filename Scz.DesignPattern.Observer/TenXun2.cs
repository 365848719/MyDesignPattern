using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scz.DesignPattern.Observer
{
    public abstract class TenXun2
    {
        private Action<TenXun2> _notifyEventHandler;

        public string Symbol { get; set; }
        public string Info { get; set; }
        protected TenXun2(string symbol, string info)
        {
            this.Symbol = symbol;
            this.Info = info;
        }

        public void AddObserver(Action<TenXun2> handler)
        {
            if (handler != null)
            {
                _notifyEventHandler += handler;
            }
        }

        public void RemoveObserver(Action<TenXun2> handler)
        {
            if (handler != null)
            {
                this._notifyEventHandler -= handler;
            }
        }

        public void Notify()
        {
            _notifyEventHandler?.Invoke(this);
        }
    }
}
