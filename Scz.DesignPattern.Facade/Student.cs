using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Facade
{
    public class Student
    {
        private RegisterFacade registerFacade = new RegisterFacade();

        public void SelectCourse()
        {
            bool isSuccess = registerFacade.RegisterCourse("设计模式", "张三。。。");
            if (isSuccess)
            {
                Console.WriteLine("选课成功！");
            }
            else
            {
                Console.WriteLine("选课失败！");
            }
        }
    }
}