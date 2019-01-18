using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scz.DesignPattern.ChainOfResponsibility
{
    public abstract class Handler
    {
        Handler nextHandler;

        public void HandleRequest(float days)
        {
            if(IsInResposibilityScope(days))
            {
                Sign();
            }
            else
            {
                if(nextHandler!=null)
                {
                    nextHandler.HandleRequest(days);
                }
                else
                {
                    Console.WriteLine("请假太久了，请直接提交辞职报告吧！");
                }
            }
        }

        public void SetNextHandler(Handler handler)
        {
            this.nextHandler = handler;
        }

        /// <summary>
        /// 这个请假天数是否在自己的职责范围内
        /// </summary>
        /// <returns></returns>
        protected abstract bool IsInResposibilityScope(float days);

        /// <summary>
        /// 领导签字，表示请假得到了审批
        /// </summary>
        protected abstract void Sign();

    }
}
