using System;

namespace Scz.DesignPattern.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            DoStrategy();
        }

        /// <summary>
        /// 策略模式
        /// </summary>
        public static void DoStrategy()
        {
            var operation = new InterestOperation(new PersonTaxStrategy());
            Console.WriteLine("个人所得税为：{0}", operation.GetTax(5000));

            operation = new InterestOperation(new EnterpriseTaxStrategy());
            Console.WriteLine("企业所得税为：{0}", operation.GetTax(5000));

            Console.Read();
        }
    }
}
