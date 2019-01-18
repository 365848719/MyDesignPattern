using System;

namespace Scz.DesignPattern.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            DoBridge();
        }

        /// <summary>
        /// 结构型：桥接模式
        /// </summary>
        public static void DoBridge()
        {
            MyDriverManager manager = new MyDriverManager();
            IDriver driver = new SqlServerDriver();
            manager.SetDriver(driver);
            manager.ConnectDatabase();
        }
    }
}
