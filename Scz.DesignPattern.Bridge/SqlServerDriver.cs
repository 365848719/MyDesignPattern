using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Bridge
{
    public class SqlServerDriver : IDriver
    {
        public void Connect()
        {
            Console.Write("Sql Server 数据库已连接！");
        }
    }
}