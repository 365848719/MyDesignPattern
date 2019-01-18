using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Bridge
{
    public abstract class DriverManager
    {
        IDriver driver;

        public IDriver GetDriver()
        {
            return this.driver;
        }
        public void SetDriver(IDriver driver)
        {
            this.driver = driver;
        }

    }
}