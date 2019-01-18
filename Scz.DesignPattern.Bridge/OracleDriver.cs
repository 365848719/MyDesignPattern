using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Bridge
{
    public class OracleDriver : IDriver
    {
        public void Connect()
        {
            Console.Write("Oracle 数据库已连接！");
        }
    }
}