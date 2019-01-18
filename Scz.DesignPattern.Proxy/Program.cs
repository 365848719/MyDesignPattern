using System;

namespace Scz.DesignPattern.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            DoProxy();
        }


        /// <summary>
        /// 代理模式
        /// </summary>
        public static void DoProxy()
        {
            Proxy proxy = new Proxy();
            proxy.Method1();
        }
    }
}
