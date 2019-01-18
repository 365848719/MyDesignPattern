using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scz.DesignPattern.Decorator
{
    /// <summary>
    /// 手机挂件，即具体装饰者
    /// </summary>
    public class Accessories:Decorator
    {
        public Accessories(Phone p) : base(p)
        {
        }

        public override void Print()
        {
            base.Print();
            this.AddAccessories();
        }

        /// <summary>
        /// 新的行为方法
        /// </summary>
        private void AddAccessories()
        {
            Console.WriteLine("现在苹果手机有漂亮的挂件了");
        }

    }
}
