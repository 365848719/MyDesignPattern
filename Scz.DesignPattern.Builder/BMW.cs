using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Builder
{
    public class BMW : IBuilder
    {
        public void CreateBody()
        {
            Console.WriteLine("创建宝马的身体！");
        }

        public void CreateChair()
        {
            Console.WriteLine("创建宝马的椅子！");
        }

        public void CreateLogo()
        {
            Console.WriteLine("创建宝马的Logo！");
        }

        public void CreateWheel()
        {
            Console.WriteLine("创建宝马的轮子！");
        }
    }
}