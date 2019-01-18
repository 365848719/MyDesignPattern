using System;

namespace Scz.DesignPattern.DelegationMode
{
    class Program
    {
        static void Main(string[] args)
        {
            var leader = new Leader();

            //看上去好像是我们的项目经理在干活
            //但实际干活的人是普通员工
            //这就是典型，干活是我的，功劳是你的

            leader.Exec("加密");
            leader.Exec("登录");

        }
    }
}
