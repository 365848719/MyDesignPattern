using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Bridge
{
    public class MysqDriver : IDriver
    {
        public void Connect()
        {
            Console.Write("My Sql 数据库已连接！");
        }
    }
}