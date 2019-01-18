using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.State
{
    /// <summary>
    /// 透支账户
    /// </summary>
    public class RedState : State
    {
        public RedState(State state)
        {
            Balance = state.Balance;
            Account = state.Account;

            Interest = 0.00;
            LowerLimit = -100.00;
            UpperLimit = 0.00;
        }

        public override string Status { get { return "透支"; } }

        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            Console.WriteLine("没有利息！");
        }

        public override void Withdraw(double amount)
        {
            Console.WriteLine("没有钱可以取了！");
        }

        private void StateChangeCheck()
        {
            if (Balance > UpperLimit )
            {
                Account.State = new SilverState(this);
            }
        }
    }
}