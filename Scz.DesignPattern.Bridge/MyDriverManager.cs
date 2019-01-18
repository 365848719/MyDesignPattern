using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Bridge
{
    public class MyDriverManager:DriverManager
    {
        public void ConnectDatabase()
        {
            GetDriver().Connect();
        }
    }
}