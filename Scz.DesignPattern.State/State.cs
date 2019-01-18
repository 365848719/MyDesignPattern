using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.State
{
    public abstract class State
    {
        /// <summary>
        /// 账户
        /// </summary>
        public Account Account { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        public double Balance { get; set; }

        /// <summary>
        /// 利率
        /// </summary>
        public double Interest { get; set; }

        /// <summary>
        /// 下限
        /// </summary>
        public double LowerLimit { get; set; }

        /// <summary>
        /// 上限
        /// </summary>
        public double UpperLimit { get; set; } 

        /// <summary>
        /// 存款
        /// </summary>
        /// <param name="amount"></param>
        public abstract void Deposit(double amount);

        /// <summary>
        /// 取钱
        /// </summary>
        /// <param name="amount"></param>
        public abstract void Withdraw(double amount);

        /// <summary>
        /// 获得的利息
        /// </summary>
        public abstract void PayInterest();

        public abstract string Status { get; }
    }
}