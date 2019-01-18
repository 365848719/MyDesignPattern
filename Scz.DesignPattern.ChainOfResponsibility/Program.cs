using System;

namespace Scz.DesignPattern.ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            ChainOfResponsibilityPattern();
        }

        /// <summary>
        /// 责任链模式（重要）
        /// </summary>
        public static void ChainOfResponsibilityPattern()
        {
            var groupLeader = new GroupLeader();
            var manager = new Manager();
            var boss = new Boss();

            //先设置好请假审批的先后顺序
            groupLeader.SetNextHandler(manager);
            manager.SetNextHandler(boss);

            //下面分别请假1、2、5、10天
            groupLeader.HandleRequest(1);
            groupLeader.HandleRequest(2);
            groupLeader.HandleRequest(5);
            groupLeader.HandleRequest(10);

        }
    }
}
