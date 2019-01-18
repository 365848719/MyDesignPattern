using System;

namespace Scz.DesignPattern.State
{
    class Program
    {
        static void Main(string[] args)
        {
            DoStatePattern();
        }

        /// <summary>
        /// 状态模式
        /// </summary>
        public static void DoStatePattern()
        {
            // 开一个新的账户
            var account = new Account("Learning Hard");

            // 进行交易
            // 存钱
            account.Deposit(1000.0);
            account.Deposit(200.0);
            account.Deposit(600.0);

            // 付利息
            account.PayInterest();

            // 取钱
            account.Withdraw(2000.00);
            account.Withdraw(500.00);

            // 等待用户输入
            Console.ReadKey();

        }

    }
}
