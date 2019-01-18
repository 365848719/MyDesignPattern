using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.State
{
    /// <summary>
    /// 银行账户根据余额可分为 RedState、SilverState和GoldState。
    /// 这些状态分别代表 透支账号，新开账户和标准账户。
    /// 
    /// 账号余额在【-100.0，0.0】范围表示处于RedState状态，
    /// 账号余额在【0.0 ， 1000.0】范围表示处于SilverState，
    /// 账号在【1000.0， 100000.0】范围表示处于GoldState状态。
    /// </summary>
    public class Account
    {
        public Account(string owner)
        {
            this.Owner = owner;
            this.State = new SilverState(0.00, this);
        }

        public string Owner
        {
            get; set;
        }

        public State State
        {
            get; set;
        }

        public double Balance => State.Balance;

        /// <summary>
        /// 存款
        /// </summary>
        public void Deposit(double amount)
        {
            State.Deposit(amount);
            Console.WriteLine(Owner + "存款金额为 {0:C}——", amount);
            Console.WriteLine("账户余额为 =:{0:C}", this.Balance);
            Console.WriteLine("账户状态为: {0}", this.State.GetType().Name);
            Console.WriteLine("账户状态2为: {0}", this.State.Status);

            Console.WriteLine();
        }

        /// <summary>
        /// 取款
        /// </summary>
        public void Withdraw(double amount)
        {
            State.Withdraw(amount);
            Console.WriteLine(Owner + "取款金额为 {0:C}——", amount);
            Console.WriteLine("账户余额为 =:{0:C}", this.Balance);
            Console.WriteLine("账户状态为: {0}", this.State.GetType().Name);
            Console.WriteLine("账户状态2为: {0}", this.State.Status);

            Console.WriteLine();
        }

        /// <summary>
        /// 获取利息
        /// </summary>
        public void PayInterest()
        {
            State.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine("账户余额为 =:{0:C}", this.Balance);
            Console.WriteLine("账户状态为: {0}", this.State.GetType().Name);
            Console.WriteLine("账户状态2为: {0}", this.State.Status);

            Console.WriteLine();
        }
    }
}