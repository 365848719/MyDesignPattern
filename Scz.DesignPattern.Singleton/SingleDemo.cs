using System;
using System.Collections.Generic;
using System.Text;

namespace Scz.DesignPattern.Singleton
{
    /// <summary>
    /// 使用内部类+静态构造函数实现延迟初始化
    /// </summary>
    public class SingleDemo
    {
        public static SingleDemo GetInstance()
        {         
            return Nested.Instance;
        }

        class Nested
        {
            static Nested() { }

            internal static readonly SingleDemo Instance = new SingleDemo();
        }
    }
}
