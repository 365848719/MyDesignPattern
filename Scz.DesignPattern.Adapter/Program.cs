using System;

namespace Scz.DesignPattern.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassAdpater();
        }

        /// <summary>
        /// 类适配器
        /// </summary>
        private static void ClassAdpater()
        {
            ITargetable targetable = new Adapter();
            targetable.Method1();

            targetable.Method2();
        }

        /// <summary>
        /// 对象适配器
        /// </summary>
        static void ObjectAdpater()
        {
            ISourceable sourceable = new Source();
            ITargetable targetable = new Wrapper(sourceable);
            targetable.Method1();

            targetable.Method2();
        }
    }
}
