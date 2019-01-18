using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scz.DesignPattern.Decorator
{
    /// <summary>
    /// 贴膜，即具体装饰者
    /// </summary>
    public class Sticker:Decorator
    {
        public Sticker(Phone p) : base(p)
        {
        }

        public override void Print()
        {
            base.Print();
            AddSticker();
        }

        /// <summary>
        /// 新的行为方法
        /// </summary>
        private void AddSticker()
        {
            Console.WriteLine("现在苹果手机有贴膜了");
        }

    }
}
