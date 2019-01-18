using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Builder
{
    public class Benz : IBuilder
    {
        public void CreateBody()
        {
            Console.WriteLine("创建大奔的身体！");
        }

        public void CreateChair()
        {
            Console.WriteLine("创建大奔的椅子！");
        }

        public void CreateLogo()
        {
            Console.WriteLine("创建大奔的Logo！");
        }

        public void CreateWheel()
        {
            Console.WriteLine("创建大奔的轮子！");
        }
    }
}